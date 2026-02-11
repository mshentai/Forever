using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Linq;
using System.IO;
using AssetDic = System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<Lunar.Building.AssetInfo>>;
using Lunar.Core;

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
                FileHelper.CreateDirByDirPath(outputPath);
                var opt = GetBuildOptions();
                var target = GetBuildTarget();
                var assetDic = GetAssetDic();
                var builds = GetBuilds(assetDic);
                LLog.Info("StartBuildAssetBundle");
                var manifest = BuildPipeline.BuildAssetBundles(outputPath, builds, opt, target);
                LLog.Info("PostBuildAssetBundles");
                PostAssetBundle(manifest, assetDic);
                AssetDatabase.SaveAssets();
                AssetDatabase.Refresh();
                LLog.Info("EndAssetBundle");
            }
            catch (System.Exception ex)
            {
                LLog.Error(ex.ToString());
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
                throw new System.Exception("No Vaild Asset");
            }

            var guids = AssetDatabase.FindAssets(string.Empty, collectPathList.ToArray());
            var guidLen = guids.Length;
            foreach (var guid in guids)
            {
                string mainAssetPath = AssetDatabase.GUIDToAssetPath(guid);
                if (!AssetDatabase.IsValidFolder(mainAssetPath))
                {
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
                }
                ++progressBarCount;
                var desc = $"progress:{progressBarCount}/{guidLen}";
                var progress = ((float)progressBarCount) / guidLen;
                EditorUtility.DisplayProgressBar("tips", desc, progress);
            }
            EditorUtility.ClearProgressBar();
            progressBarCount = 0;
            List<string> removePathList = new();

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
                var desc = $"progress:{progressBarCount}/{guidLen}";
                var progress = ((float)progressBarCount) / guidLen;
                EditorUtility.DisplayProgressBar("tips", desc, progress);
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
            info.AssetBuildLabel = HashHelper.GetMD5(label).ToLower() + ".bundle";
            info.ReadableLabel = label;
        }

        private static void PostAssetBundle(AssetBundleManifest manifest, AssetDic assetDic)
        {
            var config = AssetBundleHelper.LoadAssetBundleConfig();
            var bundleNameList = manifest.GetAllAssetBundles();
            foreach (var name in bundleNameList)
            {
                var md5 = manifest.GetAssetBundleHash(name).ToString();
                var depends = manifest.GetDirectDependencies(name);
                AssetBundleData data;
                if (config.bundleDic.ContainsKey(name))
                {
                    data = config.bundleDic[name];
                    data.Md5 = md5;
                    data.dependencies = depends;
                }
                else
                {
                    data = new AssetBundleData()
                    {
                        bundleName = name,
                        Md5 = md5,
                        dependencies = depends,
                    };
                    config.bundleDic.Add(name, data);
                }
                if (assetDic.TryGetValue(name, out var assets))
                {
                    data.assetPaths = assets.Select(v => v.AssetPath).ToArray();
                    foreach (var asset in assets)
                    {
                        config.res2bundle.Add(asset.AssetPath, name);
                    }
                }
            }
            ++config.version;
            AssetBundleHelper.SaveAssetBundleConfig(config);
        }
    }
}
