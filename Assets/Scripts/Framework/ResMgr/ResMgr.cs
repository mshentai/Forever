using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Lunar.Core
{
    public class ResMgr
    {
        private readonly LoadTaskMgr taskMgr = new LoadTaskMgr();

        public void Update()
        {
            taskMgr.Update();
        }

        public void LoadAsync(string path, Action<UnityEngine.Object> onLoaded, LoadPriority priority = LoadPriority.Normal)
        {
            var task = new LoadTask();
            task.path = path;
            task.onLoaded = onLoaded;
            task.isAsync = true;
            task.priority = priority;
            task.loader = this.GetLoader(path);
            taskMgr.dispatcher.PushTask(task);
        }


        private AssetLoader GetLoader(string path)
        {
#if UNITY_EDITOR
            return new EditorLoader();
#else
            return new AssetBundleLoader();
#endif
        }
    }
}
