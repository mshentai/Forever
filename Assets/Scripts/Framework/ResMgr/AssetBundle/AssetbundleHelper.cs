using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lunar.Core
{
    public static class AssetBundleHelper
    {
        private static string AssetBundleConfigPath => Application.streamingAssetsPath + "/AssetBundleConfig.json";
        public static AssetBundleConfig LoadAssetBundleConfig()
        {
            if (FileHelper.IsExistFile(AssetBundleConfigPath))
            {
                var json = FileHelper.ReadAllText(AssetBundleConfigPath);
                var jsonObject = JsonHelper.ToObject<AssetBundleConfigJson>(json);
                return jsonObject.ToConfig();
            }
            else
            {
                var config = new AssetBundleConfig
                {
                    version = 0,
                    bundleDic = new Dictionary<string, AssetBundleData>(),
                    res2bundle = new Dictionary<string, string>()
                };
                return config;
            }
        }

        public static void SaveAssetBundleConfig(AssetBundleConfig config)
        {
            var jsonObject = config.ToJsonObject();
            var json = JsonHelper.ToJson(jsonObject);
            FileHelper.WriteAllText(AssetBundleConfigPath, json);
        }
    }
}

