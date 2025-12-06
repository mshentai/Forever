using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Lunar.Core
{
    public class AssetBundleConfigJson
    {
        public string version;
        public AssetBundleData[] bundleList;

        public AssetBundleConfig ToConfig()
        {

            var bundleDic = new Dictionary<string, AssetBundleData>();
            foreach (var bundle in bundleList)
            {
                bundleDic.Add(bundle.bundleName, bundle);
            }
            var res2bundle = new Dictionary<string, string>();
            foreach (var bundle in bundleList)
            {
                foreach (var assetPath in bundle.assetPaths)
                {
                    res2bundle.Add(assetPath, bundle.bundleName);
                }
            }
            return new AssetBundleConfig
            {
                version = version,
                bundleDic = bundleDic,
                res2bundle = res2bundle
            };
        }
    }

    public class AssetBundleConfig
    {
        public string version;
        public Dictionary<string, AssetBundleData> bundleDic;
        public Dictionary<string, string> res2bundle;
        public AssetBundleConfigJson ToJsonObject()
        {
            var json = new AssetBundleConfigJson
            {
                version = version,
                bundleList = bundleDic.Values.ToArray()
            };
            return json;
        }
    }

    public class AssetBundleData
    {
        public string bundleName;
        public string Md5;
        public string[] assetPaths;
        public string[] dependencies;
    }
}

