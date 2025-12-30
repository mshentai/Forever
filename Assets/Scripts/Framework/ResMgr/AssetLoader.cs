using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lunar.Core
{
    public abstract class AssetLoader
    {
        private LoaderState state = LoaderState.Unloaded;
        public UnityEngine.Object Asset { get; protected set; }
        public string ResPath { get; protected set; }
        public LoaderState State
        {
            get => this.state;
            protected set
            {
                this.state = value;
                dependentHandles.ForEach(handle => handle.OnLoadStateChanged(this.state));
            }
        }
        protected List<LoadHandle> dependentHandles;
        protected List<LoadHandle> dependencyHandles;
        public T GetAsset<T>() where T : UnityEngine.Object
        {
            return Asset as T;
        }
        public string GetAssetName()
        {
            return FileHelper.GetFileName(this.ResPath);
        }

        public abstract void Load(string path, Action<UnityEngine.Object> onLoaded);

        public abstract void LoadAsync(string path, Action<UnityEngine.Object> onLoaded);

        public virtual void Release(LoadHandle handle)
        {
            if (this.State == LoaderState.Loaded)
            {
                dependentHandles.Remove(handle);
                if (this.dependentHandles.Count == 0)
                {
                    this.UnLoad();
                }
            }
        }
        public virtual void Reference(LoadHandle handle)
        {
            if (this.dependentHandles.Contains(handle) == false)
            {
                this.dependentHandles.Add(handle);
            }
        }

        protected virtual void UnLoad()
        {
            this.State = LoaderState.Unloaded;
            this.dependencyHandles.ForEach(h => h.Release());
            this.dependencyHandles.Clear();
            this.dependentHandles.Clear();
            this.Asset = null;
        }

        public virtual void Cancel()
        {
            if (this.State == LoaderState.Loading)
            {
                this.State = LoaderState.Unloaded;
                this.Asset = null;
                this.dependencyHandles.ForEach(handle => handle.Release());
                this.dependencyHandles.Clear();
                this.dependentHandles.Clear();
            }
        }
    }
}

