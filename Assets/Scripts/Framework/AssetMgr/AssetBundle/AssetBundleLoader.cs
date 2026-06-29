using System;
using System.Collections.Generic;
using Lunar.Core;
using UnityEngine;

namespace Lunar.GamePlay
{
    public class AssetBundleLoader : AssetLoader
    {
        public override void Load(string path, Action<UnityEngine.Object> onLoaded)
        {
            throw new NotImplementedException();
        }

        public override void LoadAsync(string path, Action<UnityEngine.Object> onLoaded)
        {
            throw new NotImplementedException();
        }
    }
}