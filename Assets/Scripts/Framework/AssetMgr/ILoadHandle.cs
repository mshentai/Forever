using System;
using System.Collections;
using Lunar.Core;

public interface ILoadHandle : IEnumerator
{
    bool IsDone { get; }
    string Error { get; }
    bool IsSuccessful { get; }
    event Action<ILoadHandle> Completed;
    void Cancel();
    void Release();
    T GetAsset<T>() where T : UnityEngine.Object;
    void OnLoadStateChanged(LoaderState state);
}