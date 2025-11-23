using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lunar.Core
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

        public override void Release()
        {
            throw new NotImplementedException();
        }
    }
}

