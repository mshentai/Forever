using System;
using System.Collections;
using System.Collections.Generic;
using Lunar.Core;
using UnityEngine;

public class ABLoadHandle : ILoadHandle
{
    public bool IsDone => throw new NotImplementedException();

    public string Error => throw new NotImplementedException();

    public bool IsSuccessful => throw new NotImplementedException();

    public object Current => throw new NotImplementedException();

    public event Action<ILoadHandle> Completed;

    public void Cancel()
    {
        throw new NotImplementedException();
    }

    public T GetAsset<T>() where T : UnityEngine.Object
    {
        throw new NotImplementedException();
    }

    public bool MoveNext()
    {
        throw new NotImplementedException();
    }

    public void OnLoadStateChanged(LoaderState state)
    {
        throw new NotImplementedException();
    }

    public void Release()
    {
        throw new NotImplementedException();
    }

    public void Reset()
    {
        throw new NotImplementedException();
    }
}
