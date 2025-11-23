using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lunar.Core
{
    public class ABLoader : AssetLoader
    {
        public AssetBundle assetBundle;
        public override void Load(string path, Action<UnityEngine.Object> onLoaded)
        {
            this.ResPath = path;
            string bundlePath = this.GetAssetBundlePath(path);
            AssetBundle bundle = AssetBundle.LoadFromFile(bundlePath);
            this.assetBundle = bundle;
            var name = this.GetAssetName();
            this.asset = bundle.LoadAsset(name);
        }

        public override void LoadAsync(string path, Action<UnityEngine.Object> onLoaded)
        {
            this.ResPath = path;
            string bundlePath = GetAssetBundlePath(path);
            AssetBundle.LoadFromFileAsync(bundlePath);
        }

        public string GetAssetBundlePath(string path)
        {
            string md5 = HashUtils.GetMD5(path);
            string bundlePath = string.Format(PathDefine.bundleLoadPathFormat, md5);
            return bundlePath;
        }

        public override void Release()
        {
            ((AssetBundle)this.asset).UnloadAsync(true);
        }
    }
}

