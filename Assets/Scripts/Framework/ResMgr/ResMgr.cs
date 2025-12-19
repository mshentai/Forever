using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Lunar.Core
{
    public class ResMgr
    {
        private readonly LoadTaskMgr taskMgr = new LoadTaskMgr();
        private readonly Dictionary<string, AssetLoader> loaderCache = new();

        public void Update()
        {
            taskMgr.Update();
        }

        public LoadHandle<T> LoadAsync<T>(string path, LoadPriority priority = LoadPriority.Normal)
        {
            if (loaderCache.TryGetValue(path, out var loader) && (loader.State != LoaderState.Faild))
            {
                return new LoadHandle<T>(loader);
            }
            else
            {
                loader = this.GetLoader(path);
                var task = new LoadTask
                {
                    path = path,
                    isAsync = true,
                    priority = priority,
                    loader = loader,
                };
                loaderCache[path] = loader;
                taskMgr.dispatcher.PushTask(task);
                return new LoadHandle<T>(loader);
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
