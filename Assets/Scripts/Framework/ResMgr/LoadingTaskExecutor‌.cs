using System.Collections.Generic;
using UnityEditorInternal;

namespace Lunar.Core
{
    public class LoadingTaskExecutor
    {
        private readonly List<TaskExecutorUnit> units;
        private readonly int maxUnitCount = 10;

        public LoadingTaskExecutor()
        {
            units = new List<TaskExecutorUnit>(maxUnitCount);
            for (int i = 0; i < maxUnitCount; i++)
            {
                units.Add(new TaskExecutorUnit());
            }
        }

        public bool TryGetExcutorUnit(out TaskExecutorUnit unit)
        {
            for (int i = 0; i < units.Count; i++)
            {
                if (units[i].isFinished)
                {
                    unit = units[i];
                    return true;
                }
            }
            unit = null;
            return false;
        }
    }
}