#if UNITY_EDITOR
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Lunar.Core
{
    public class EditorLoader : AssetLoader
    {
        public override void Load(string path, Action<UnityEngine.Object> onLoaded)
        {
            var t = AssetDatabase.LoadAssetAtPath<UnityEngine.Object>(path);
            this.Asset = t;
            this.State = LoaderState.Loaded;
            onLoaded(t);
        }

        public override void LoadAsync(string path, Action<UnityEngine.Object> onLoaded)
        {
            var t = AssetDatabase.LoadAssetAtPath<UnityEngine.Object>(path);
            this.Asset = t;
            this.State = LoaderState.Loaded;
            onLoaded(t);
        }
    }
}
#endif