using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lunar.Core
{
    public class TaskExecutorUnit
    {
        public LoadTask task;
        public bool isFinished = true;

        public void Excute(LoadTask task)
        {
            this.task = task;
            this.isFinished = false;
            // if (task.isAsync)
            // {
            //     task.loadHandle.LoadAsync(task.path, this.OnTaskFinished);
            // }
            // else

            // {
            //     task.loadHandle.Load(task.path, this.OnTaskFinished);
            // }
        }

        public void Cancel()
        {
            // todo: 取消加载
            this.isFinished = true;
        }

        private void OnTaskFinished(UnityEngine.Object asset)
        {
            isFinished = true;
        }
    }
}

