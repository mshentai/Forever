using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Linq;
using System.IO;
using AssetDic = System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<Lunar.Building.AssetInfo>>;

namespace Lunar.Building
{
    public static class PackTool
    {
        [MenuItem("Tools/StartBundle")]
        public static void StartAssetBundle()
        {
            try
            {
                var outputPath = PathDefine.bundlePath;
                FileTool.CreateDirByDirPath(outputPath);
                var opt = GetBuildOptions();
                var target = GetBuildTarget();
                var assetDic = GetAssetDic();
                var builds = GetBuilds(assetDic);
                var manifest = BuildPipeline.BuildAssetBundles(outputPath, builds, opt, target);
                PostAssetBundle(manifest, assetDic);
                AssetDatabase.SaveAssets();
                AssetDatabase.Refresh();
                Debug.Log("EndAssetBundle");
            } 
            catch (System.Exception ex)
            {
                Debug.LogError(ex);
            }
        }

        private static BuildTarget GetBuildTarget()
        {
            return BuildTarget.StandaloneWindows;
        }

        private static BuildAssetBundleOptions GetBuildOptions()
        {
            BuildAssetBundleOptions opt = BuildAssetBundleOptions.None;
            opt |= BuildAssetBundleOptions.StrictMode;
            opt |= BuildAssetBundleOptions.DeterministicAssetBundle;

            return opt;
        }

        private static AssetDic GetAssetDic()
        {
            var map = new AssetDic();
            var infoList = GetAssetInfoList();
            foreach (var info in infoList)
            {
                var key = info.AssetBuildLabel;
                if (!map.ContainsKey(key))
                {
                    map.Add(key, new List<AssetInfo>());
                }
                map[key].Add(info);
            }
            return map;
        }

        private static AssetBundleBuild[] GetBuilds(Dictionary<string, List<AssetInfo>> map)
        {

            var builds = new List<AssetBundleBuild>();
            foreach (var pair in map)
            {
                builds.Add(new AssetBundleBuild()
                {
                    assetBundleName = pair.Key,
                    assetNames = pair.Value.Select(v => v.AssetPath).ToArray(),
                });
            }
            return builds.ToArray();
        }

        private static List<AssetInfo> GetAssetInfoList()
        {
            int progressBarCount = 0;
            Dictionary<string, AssetInfo> allAssets = new Dictionary<string, AssetInfo>();
            var collectPathList = CollectionHandle.GetAllCollectPath();
            if (collectPathList.Count == 0)
            {
                throw new System.Exception("打包路径列表为空");
            }

            var guids = AssetDatabase.FindAssets(string.Empty, collectPathList.ToArray());
            var guidLen = guids.Length;
            foreach (var guid in guids)
            {
                string mainAssetPath = AssetDatabase.GUIDToAssetPath(guid);
                List<AssetInfo> depends = GetDependencies(mainAssetPath);
                foreach (var d in depends)
                {
                    if (allAssets.ContainsKey(d.AssetPath))
                    {
                        ++allAssets[d.AssetPath].DependCount;
                    }
                    else
                    {
                        allAssets.Add(d.AssetPath, d);
                    }
                }
                ++progressBarCount;
                var desc = $"依赖文件分析:{progressBarCount}/{guidLen}";
                var progress = ((float)progressBarCount) / guidLen;
                EditorUtility.DisplayProgressBar("进度", desc, progress);
            }
            EditorUtility.ClearProgressBar();
            progressBarCount = 0;
            List<string> removePathList = new List<string>();
            foreach (var pair in allAssets)
            {
                if (!pair.Value.IsCollectAsset)
                {
                    if (pair.Value.DependCount == 0)
                    {
                        removePathList.Add(pair.Key);
                    } 
                }
            }
            removePathList.ForEach(v => allAssets.Remove(v));
            foreach (var pair in allAssets)
            {
                SetAssetBundleLabelAndVariant(pair.Value);
                ++progressBarCount;
                var desc = $"设置资源标签:{progressBarCount}/{guidLen}";
                var progress = ((float)progressBarCount) / guidLen;
                EditorUtility.DisplayProgressBar("进度", desc, progress);
            }
            EditorUtility.ClearProgressBar();
            progressBarCount = 0;
            return allAssets.Values.ToList();
        }

        private static List<AssetInfo> GetDependencies(string assetPath)
        {
            List<AssetInfo> dependInfoList = new List<AssetInfo>();
            string[] dependArr = AssetDatabase.GetDependencies(assetPath, true);
            foreach (var depend in dependArr)
            {
                var info = new AssetInfo(depend);
                dependInfoList.Add(info);
            }
            return dependInfoList;
        }

        private static void SetAssetBundleLabelAndVariant(AssetInfo info)
        {
            var label = CollectionHandle.GetAssetBuildLabel(info.AssetPath);
            Debug.LogError($"{label}, {HashUtils.GetMD5(label)}");
            info.AssetBuildLabel = HashUtils.GetMD5(label) + ".bundle";
            info.ReadableLabel = label;
        }

        private static void PostAssetBundle(AssetBundleManifest manifest, AssetDic assetDic)
        {
            var resMap = GetOldResMap();
            var bundleNameList = manifest.GetAllAssetBundles();
            foreach (var name in bundleNameList)
            {
                var md5 = manifest.GetAssetBundleHash(name).ToString();
                var depends = manifest.GetDirectDependencies(name);
                if (resMap.ContainsKey(name))
                {
                    var node = resMap[name];
                    node.MD5 = md5;
                } 
                else
                {
                    var node = new AssetNode(name, md5, depends);
                    resMap[name] = node;
                }
            }
            SaveResMap(resMap);
        }

        private static Dictionary<string, AssetNode> GetOldResMap()
        {
            var resMap = new Dictionary<string, AssetNode>();
            var manifestPath = PathDefine.manifestPath;
            using (var reader = new StreamReader(File.Open(manifestPath, FileMode.OpenOrCreate)))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    string[] arr = line.Split('=');
                    if (arr.Length >= 3)
                    {
                        var bundleName = arr[0];
                        var bundleMD5 = arr[1];
                        var defends = arr[2].Split(',');
                        var node = new AssetNode(bundleName, bundleMD5, defends);
                        resMap.Add(bundleName, node);
                    }
                }
            }
            return resMap;
        }

        private static void SaveResMap(Dictionary<string, AssetNode> map)
        {
            var manifestPath = PathDefine.manifestPath;
            using (var writer = new StreamWriter(File.Open(manifestPath, FileMode.OpenOrCreate)))
            {
                var builder = new System.Text.StringBuilder();
                foreach (var pair in map)
                {
                    builder.Clear();
                    var node = pair.Value;
                    var defends = string.Join(',', node.Dependencies);
                    builder.AppendJoin('=', node.Name, node.MD5, defends);
                    writer.WriteLine(builder.ToString());
                }
            }
        }

    }
}
