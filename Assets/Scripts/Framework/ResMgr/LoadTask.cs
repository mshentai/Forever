using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lunar.Resource
{
    public class LoadTask
    {
        public LoadPriority priority;
        public bool isAsync;

        public string path;

        public System.Action<UnityEngine.Object> onLoaded;
        public AssetLoader loader;
    }
}