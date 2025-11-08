using System;
using System.Collections;

public interface ILoadHandle<T> : IEnumerator
{
    bool IsDone { get; }
    float Progress { get; }
    T Result { get; }
    string Error { get; }
    bool IsSuccessful { get; }

    event Action<ILoadHandle<T>> Completed;
    void Cancel();
}