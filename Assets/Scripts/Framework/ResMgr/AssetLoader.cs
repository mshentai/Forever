using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lunar.Resource
{
    public abstract class AssetLoader
    {
        public UnityEngine.Object asset;
        public string ResPath { get; protected set; }
        public LoaderState State { get; protected set; }
        public int RefCount { get; protected set; }

        public T GetAsset<T>() where T : UnityEngine.Object
        {
            return asset as T;
        }
        public string GetAssetName()
        {
            return FileTool.GetFileName(this.ResPath);
        }

        public abstract void Load(string path, Action<UnityEngine.Object> onLoaded);

        public abstract void LoadAsync(string path, Action<UnityEngine.Object> onLoaded);

        public abstract void Unload();
    }
}

