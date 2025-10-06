using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lunar.Resource
{
    public class TaskExecutorUnit
    {
        public LoadTask task;
        public bool isFinished = true;

        public void Excute(LoadTask task)
        {
            this.task = task;
            this.isFinished = false;
            if (task.isAsync)
            {
                task.loader.LoadAsync(task.path, this.OnTaskFinished);
            }
            else
            {
                task.loader.Load(task.path, this.OnTaskFinished);
            }
        }

        public void Cancel()
        {
            this.isFinished = true;
        }

        private void OnTaskFinished(UnityEngine.Object asset)
        {
            isFinished = true;
            this.task.onLoaded?.Invoke(asset);
        }
    }
}

