using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Lunar.Core;

public class LoadHandle<T> : ILoadHandle<T>
{
    public bool IsDone => loader.State == LoaderState.Loaded || loader.State == LoaderState.Faild;
    public bool IsSuccessful => loader.State == LoaderState.Loaded;
    public T Result { get; }
    public string Error { get; }
    public event Action<ILoadHandle<T>> Completed;
    bool IEnumerator.MoveNext() => !IsDone;
    void IEnumerator.Reset() { }
    public void Dispose() => Release();
    public void Release() => this.loader.Release();
    public object Current => null;
    private AssetLoader loader;
    public LoadHandle(AssetLoader loader)
    {
        this.loader = loader;
        this.loader.Refenece();
    }
    public void Cancel()
    {
        // todo: 这个功能没有经过良好设计，需要重构
        this.loader.Cancel();
    }
}
