using System.Collections.Generic;
using System.Linq;
using Lunar.Extensions;

namespace Lunar.Resource
{
    public class LoadingTaskDispatcher
    {
        private List<Queue<LoadTask>> taskQueues;
        private readonly int minPriority;
        private readonly int maxPriority;
        public int TotalTaskCount => taskQueues.Sum(queue => queue.Count);

        public LoadingTaskDispatcher()
        {
            this.minPriority = EnumExtension.GetMinIntValue<LoadPriority>();
            this.maxPriority = EnumExtension.GetMaxIntValue<LoadPriority>();
            int queueCount = maxPriority - minPriority + 1;
            taskQueues = new List<Queue<LoadTask>>(queueCount);
            for (int i = 0; i < queueCount; i++)
            {
                taskQueues.Add(new Queue<LoadTask>());
            }
        }

        public void PushTask(LoadTask task)
        {
            if (task == null) return;
            int priorityIndex = task.priority.ToInt() - minPriority;

            // 边界检查
            if (priorityIndex >= 0 && priorityIndex < taskQueues.Count)
            {
                taskQueues[priorityIndex].Enqueue(task);
            }
            else
            {
                // 处理优先级超出范围的情况
                UnityEngine.Debug.LogWarning($"task Priority out of range: {task.priority}");
                // 可以选择放入最高或最低优先级队列
                taskQueues[0].Enqueue(task); // 放入最高优先级
            }
        }

        public LoadTask PopTask()
        {
            for (int i = 0; i < taskQueues.Count; i++)
            {
                if (taskQueues[i].Count > 0)
                {
                    return taskQueues[i].Dequeue();
                }
            }
            return null;
        }

        public bool TryGetTask(out LoadTask task)
        {
            task = this.PopTask();
            return task != null;
        }

        public void Clear()
        {
            foreach (var queue in taskQueues)
            {
                queue.Clear();
            }
        }

        // 获取队列状态（用于调试和监控）
        public int GetQueueCount(LoadPriority priority)
        {
            int index = priority.ToInt() - minPriority;
            if (index >= 0 && index < taskQueues.Count)
            {
                return taskQueues[index].Count;
            }
            return 0;
        }
    }
}