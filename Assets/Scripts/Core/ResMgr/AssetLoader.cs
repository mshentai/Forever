using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lunar.Resource
{
    public delegate void OnLoaded(Object asset);
    public abstract class AssetLoader
    {
        public Object asset;
        public string ResPath { get; protected set; }
        public LoaderState State { get; protected set; }
        protected OnLoaded onLoaded;

        public Object GetAsset()
        {
            return asset;
        }
        public string GetAssetName()
        {
            return FileTool.GetFileName(this.ResPath);
        }

        public abstract Object Load(string path);

        public abstract void LoadAysnc(string path, OnLoaded onLoaded);

        public abstract void Unload();
    }
}

