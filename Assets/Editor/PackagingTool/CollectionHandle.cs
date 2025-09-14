using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Linq;

namespace Lunar.Building
{
    public static class CollectionHandle
    {
        public static CollectionSetting setting;
        static CollectionHandle()
        {
            var settingPath = PathDefine.collectionSettingPath;
            setting = AssetDatabase.LoadAssetAtPath<CollectionSetting>(settingPath);
            if (setting == null)
            {
                setting = ScriptableObject.CreateInstance<CollectionSetting>();
                FileTool.CreateDirByFilePath(settingPath);
                AssetDatabase.CreateAsset(setting, settingPath);
                AssetDatabase.SaveAssets();
                AssetDatabase.Refresh();
            } 
            else
            {
                Debug.Log("Load CollectionSetting is Ok");
            }
        }

        public static bool IsCollectAsset(string assetPath)
        {
            foreach (var wrap in setting.elements)
            {
                if (wrap.PackRule == PackRule.Collect && assetPath.StartsWith(wrap.DirPath))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsSubPath(string parent, string child)
        {
            return child.StartsWith(parent) && child[parent.Length] == '/';
        }

        public static Wrapper GetWrapper(string assetPath)
        {
            Wrapper res = null;
            foreach (var wrap in setting.elements)
            {
                if (assetPath.StartsWith(wrap.DirPath))
                {
                    if (res == null || res.DirPath.Length <= wrap.DirPath.Length)
                    {
                        res = wrap;
                    }
                }
            }
            return res;
        }

        public static List<string> GetAllCollectPath()
        {
            var allCollect = setting.elements.FindAll(warp => warp.PackRule == PackRule.Collect);
            return allCollect.Select(wrap => wrap.DirPath).ToList();
        }

        public static string GetAssetBuildLabel(string assetPath)
        {
            var wrap = GetWrapper(assetPath);
            string res;
            switch (wrap.LabelRule)
            {
                case LabelRule.LabelByFileName:
                    res = FileTool.GetFileName(assetPath);
                    break;
                case LabelRule.LabelByFilePath:
                    res = assetPath.Remove(assetPath.LastIndexOf('.'));
                    break;
                case LabelRule.LabelByDirName:
                    res = FileTool.GetFileName(FileTool.GetDirPath(assetPath));
                    break;
                case LabelRule.LabelByDirPath:
                    res = FileTool.GetDirPath(assetPath);
                    break;
                default:
                    res = FileTool.GetFileName(assetPath);
                    break;
            }
            return res;
        }

        public static BundleType GetAssetBundleType(string assetPath)
        {
            var wrap = GetWrapper(assetPath);
            return wrap?.BundleType ?? BundleType.BuildIn;
        }
    }
}
