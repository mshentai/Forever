using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ABLoadHandle : ILoadHandle<AssetBundle>
{
    public bool IsDone => throw new NotImplementedException();

    public AssetBundle Result => throw new NotImplementedException();

    public string Error => throw new NotImplementedException();

    public bool IsSuccessful => throw new NotImplementedException();

    public object Current => throw new NotImplementedException();

    public event Action<ILoadHandle<AssetBundle>> Completed;

    public void Cancel()
    {
        throw new NotImplementedException();
    }

    public bool MoveNext()
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
