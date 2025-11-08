using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LoadHandle<T> : ILoadHandle<T>
{
    public bool IsDone { get; }
    public float Progress { get; }
    public T Result { get; }
    public string Error { get; }
    public bool IsSuccessful { get; }
    public event Action<ILoadHandle<T>> Completed;

    public void Cancel()
    {
        throw new NotImplementedException();
    }

    public void Reset()
    {
        throw new NotImplementedException();
    }

    bool IEnumerator.MoveNext()
    {
        throw new NotImplementedException();
    }

    public object Current { get; }
}
