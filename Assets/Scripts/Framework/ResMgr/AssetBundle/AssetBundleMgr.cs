using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetBundleMgr
{
    private Dictionary<string, AssetBundle> m_AssetBundleMap = new();

    public ABLoadHandle LoadAssetBundle(string path)
    {
        if (m_AssetBundleMap.TryGetValue(path, out var bundle))
        {
            return new ABLoadHandle();
        }
        else
        {
            m_AssetBundleMap.Add(path, bundle);
            return new ABLoadHandle();
        }
    }


}
