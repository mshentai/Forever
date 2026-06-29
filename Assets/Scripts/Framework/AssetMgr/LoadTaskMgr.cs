using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lunar.Core
{
    public class LoadTaskMgr
    {
        public readonly LoadingTaskDispatcher dispatcher;
        public readonly LoadingTaskExecutor executor;

        public LoadTaskMgr()
        {
            dispatcher = new LoadingTaskDispatcher();
            executor = new LoadingTaskExecutor();
        }

        public void Update()
        {
            if (dispatcher.TryGetTask(out LoadTask task))
            {
                if (executor.TryGetExcutorUnit(out TaskExecutorUnit unit))
                {
                    unit.Excute(task);
                }
            }
        }
    }
}