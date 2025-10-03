using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lunar.Resource 
{
    public class ABLoader : AssetLoader
    {
        public override Object Load(string path)
        {
            this.ResPath = path;
            string bundlePath = this.GetAssetBundlePath(path);
            AssetBundle bundle = AssetBundle.LoadFromFile(bundlePath);
            this.asset = bundle;
            var name = this.GetAssetName();
            return bundle.LoadAsset(name);
        }

        public override void LoadAysnc(string path, OnLoaded onLoaded)
        {
            this.ResPath = path;
            this.onLoaded = onLoaded;
            string bundlePath = GetAssetBundlePath(path);
            AssetBundle.LoadFromFileAsync(bundlePath);
        }

        public string GetAssetBundlePath(string path)
        {
            string md5 = HashUtils.GetMD5(path);
            string bundlePath = string.Format(PathDefine.bundleLoadPathFormat, md5);
            return bundlePath;
        }

        public override void Unload()
        {
            ((AssetBundle)this.asset).UnloadAsync(true);
        }
    }
}

