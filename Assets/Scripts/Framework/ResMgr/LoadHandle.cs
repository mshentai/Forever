using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Lunar.Core;

public class LoadHandle : ILoadHandle
{
    public bool IsDone => loader.State == LoaderState.Loaded || loader.State == LoaderState.Faild;
    public bool IsSuccessful => loader.State == LoaderState.Loaded;
    public string Error { get; }
    public event Action<ILoadHandle> Completed;
    public object Current => null;
    private AssetLoader loader;
    private bool isReferenced = false;
    public LoadHandle(AssetLoader loader)
    {
        this.loader = loader;
        this.loader.Reference(this);
        this.isReferenced = true;
        if (this.IsSuccessful)
        {
            this.Completed?.Invoke(this);
        }
    }
    public void Cancel()
    {
        // todo: 这个功能没有经过良好设计，需要重构
        this.loader.Cancel();
    }
    public T GetAsset<T>() where T : UnityEngine.Object
    {
        return this.loader.GetAsset<T>();
    }
    public void Release()
    {
        if (this.isReferenced)
        {
            this.isReferenced = false;
            this.loader.Release(this);
        }
    }
    public void OnLoadStateChanged(LoaderState state)
    {
        if (state == LoaderState.Loaded)
        {
            this.Completed?.Invoke(this);
        }
    }
    bool IEnumerator.MoveNext() => !IsDone;
    void IEnumerator.Reset() { }
    public void Dispose() => Release();
    ~LoadHandle() => Dispose();
}