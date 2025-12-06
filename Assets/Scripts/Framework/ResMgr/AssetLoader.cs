using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lunar.Core
{
    public abstract class AssetLoader
    {
        public UnityEngine.Object asset;
        public string ResPath { get; protected set; }
        public LoaderState State { get; protected set; }
        public int RefCount { get; protected set; }
        public List<ILoadHandle<UnityEngine.Object>> referenceHandles;
        public T GetAsset<T>() where T : UnityEngine.Object
        {
            return asset as T;
        }
        public string GetAssetName()
        {
            return FileHelper.GetFileName(this.ResPath);
        }

        public abstract void Load(string path, Action<UnityEngine.Object> onLoaded);

        public abstract void LoadAsync(string path, Action<UnityEngine.Object> onLoaded);

        public virtual void Release()
        {
            if (this.State == LoaderState.Loaded)
            {
                --this.RefCount;
                if (this.RefCount == 0)
                {
                    this.UnLoad();
                }
            }
        }
        public virtual void Refenece()
        {
            ++this.RefCount;
        }

        protected virtual void UnLoad()
        {
            this.State = LoaderState.Unloaded;
            this.referenceHandles.ForEach(h => h.Release());
            this.asset = null;
            this.RefCount = 0;
        }

        public virtual void Cancel()
        {
            if (this.State == LoaderState.Loading)
            {
                this.State = LoaderState.Unloaded;
                this.asset = null;
                this.RefCount = 0;
            }
        }
    }
}

