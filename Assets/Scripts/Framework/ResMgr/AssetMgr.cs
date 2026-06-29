using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Lunar.Core
{
    public class AssetMgr
    {
        private readonly LoadTaskMgr taskMgr = new LoadTaskMgr();
        private readonly Dictionary<string, AssetLoader> loaderCache = new();

        public void Update()
        {
            taskMgr.Update();
        }

        public LoadHandle LoadAsync(string path, LoadPriority priority = LoadPriority.Normal)
        {
            if (loaderCache.TryGetValue(path, out var loader) && (loader.State != LoaderState.Faild))
            {
                return new LoadHandle(loader);
            }
            else
            {
                loader = this.GetLoader(path);
                var handle = new LoadHandle(loader);
                var task = new LoadTask
                {
                    path = path,
                    isAsync = true,
                    priority = priority,
                    loadHandle = handle,
                    loader = loader
                };
                loaderCache[path] = loader;
                taskMgr.dispatcher.PushTask(task);
                return handle;
            }
        }

        private AssetLoader GetLoader(string path)
        {
#if UNITY_EDITOR
            return new EditorLoader();
#else
            return new ABLoader();
#endif
        }
    }
}
