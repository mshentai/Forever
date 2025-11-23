using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lunar.Core
{
    public class LoadTask
    {
        public LoadPriority priority;
        public bool isAsync;
        public string path;
        public AssetLoader loader;
    }
}