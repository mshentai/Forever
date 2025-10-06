#if UNITY_EDITOR
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Lunar.Resource
{
    public class EditorLoader : AssetLoader
    {
        public override void Load(string path, Action<UnityEngine.Object> onLoaded)
        {
            var t = AssetDatabase.LoadAssetAtPath<UnityEngine.Object>(path);
            this.asset = t;
            onLoaded(t);
        }

        public override void LoadAsync(string path, Action<UnityEngine.Object> onLoaded)
        {
            var t = AssetDatabase.LoadAssetAtPath<UnityEngine.Object>(path);
            this.asset = t;
            onLoaded(t);
        }

        public override void Unload()
        {
            Resources.UnloadAsset(this.asset);
        }
    }
}
#endif