using System;
using System.Collections.Generic;
using Lunar.Core;
using Lunar.Utilities;
using UnityEngine;

namespace Lunar.Core
{
    public class TimerManager : Singleton<TimerManager>
    {
        private readonly Dictionary<Type, List<ITimer>> timerCache = new();
        private readonly Dictionary<int, ITimer> activeTimers = new();
        private readonly List<ITimer> timersToAdd = new();
        private readonly List<ITimer> timersToRemove = new();

        protected override void OnReset()
        {
            base.OnReset();
            this.ClearAll();
        }

        private void AddTimer(ITimer timer)
        {
            if (!activeTimers.ContainsKey(timer.Id))
            {
                var notExistInAdd = !timersToAdd.Contains(timer);
                if (notExistInAdd)
                {
                    timersToAdd.Add(timer);
                }
                else
                {
                    Debug.LogError($"Timer {timer.Id} is already added");
                }
            }
            if (timersToRemove.Contains(timer))
            {
                timersToRemove.Remove(timer);
            }
        }

        public void RemoveTimer(ITimer timer)
        {
            if (activeTimers.ContainsKey(timer.Id))
            {
                var notExistInRemove = !timersToRemove.Contains(timer);
                if (notExistInRemove)
                {
                    timersToRemove.Add(timer);
                }
                else
                {
                    Debug.LogError($"Timer {timer.Id} is already removed");
                }
            }
            if (timersToAdd.Contains(timer))
            {
                timersToAdd.Remove(timer);
                return;
            }
            Debug.LogError($"Trying to remove a {timer.Id} that is not active.");
        }

        private void AddTimerInternal(ITimer timer)
        {
            var isNotActive = !this.activeTimers.ContainsKey(timer.Id);
            if (isNotActive)
            {
                this.activeTimers.Add(timer.Id, timer);
            }
            else
            {
                Debug.LogError($"Trying to add a {timer.Id} that is already active.");
            }
        }

        private void RemoveTimerInternal(ITimer timer)
        {
            var isActive = this.activeTimers.ContainsKey(timer.Id);
            if (isActive)
            {
                this.activeTimers.Remove(timer.Id);
                this.RecycleTimer(timer);
            }
            else
            {
                Debug.LogError($"Trying to remove a {timer.Id} that is not active.");
            }
        }

        private void RecycleTimer(ITimer timer)
        {
            timer.Recycle();
            var type = timer.GetType();
            if (!timerCache.TryGetValue(type, out var list))
            {
                list = new List<ITimer>();
                timerCache.Add(type, list);
            }
            list.Add(timer);
        }

        private T GenerateTimer<T>() where T : class, ITimer, new()
        {
            var type = typeof(T);
            if (timerCache.TryGetValue(type, out var list))
            {
                if (list.Count > 0)
                {
                    var lastIndex = list.Count - 1;
                    var timer = list[lastIndex];
                    list.RemoveAt(lastIndex);
                    return timer as T;
                }
            }
            return new T();
        }

        public void ClearAll()
        {
            timerCache.Clear();
            activeTimers.Clear();
            timersToAdd.Clear();
            timersToRemove.Clear();
        }

        public void Update()
        {
            foreach (var kv in activeTimers)
            {
                var timer = kv.Value;
                timer.Update(Time.deltaTime);
                if (!timer.IsRunning)
                {
                    this.RemoveTimerInternal(timer);
                }
            }
            if (timersToAdd.Count > 0)
            {
                foreach (var timer in timersToAdd)
                {
                    this.AddTimerInternal(timer);
                }
                timersToAdd.Clear();
            }
            if (timersToRemove.Count > 0)
            {
                foreach (var timer in timersToRemove)
                {
                    this.RemoveTimerInternal(timer);
                }
                this.timersToRemove.Clear();
            }
        }

        public ITimer AddTimer(float duration, Action onComplete)
        {
            var timer = this.GenerateTimer<OnceTimer>();
            timer.Init(duration, onComplete);
            this.AddTimer(timer);
            return timer;
        }

        public ITimer AddLoopTimer(float interval, int repeatCount, Action onTick, Action onComplete = null)
        {
            var timer = this.GenerateTimer<LoopTimer>();
            timer.Init(interval, repeatCount, onTick, onComplete);
            this.AddTimer(timer);
            return timer;
        }
    }
}
public interface ITimer
{
    int Id { get; }
    bool IsRunning { get; }
    void Update(float deltaTime);
    void Recycle();
}

public class BaseTimer : ITimer
{
    public int Id { get; private set; }
    public bool IsRunning { get; private set; } = false;
    private Action onComplete;
    public float Duration { get; private set; }
    public float CurrentTime { get; private set; }

    public void InitBase(float duration, Action onComplete)
    {
        this.Id = GetNextId();
        this.Duration = duration;
        this.onComplete = onComplete;
        this.IsRunning = true;
        this.CurrentTime = 0f;
    }

    public virtual void Update(float deltaTime)
    {
        this.CurrentTime += deltaTime;
        if (this.CurrentTime >= this.Duration)
        {
            Complete();
        }
    }

    private void Complete()
    {
        onComplete?.Invoke();
        IsRunning = false;
    }

    private int GetNextId()
    {
        return UIDSystem.Instance.NextInt(UIDType.Timer);
    }

    public virtual void Recycle()
    {
        this.Id = 0;
        this.Duration = 0f;
        this.CurrentTime = 0f;
        this.onComplete = null;
    }
}

public class OnceTimer : BaseTimer
{
    public void Init(float duration, Action onComplete)
    {
        InitBase(duration, onComplete);
    }
}

public class LoopTimer : BaseTimer
{
    private float interval;
    private Action onTick;
    private float nextTickTime;
    private float t;
    public void Init(float interval, int repeatCount, Action onTick, Action onComplete = null)
    {
        this.interval = interval;
        this.onTick = onTick;
        var duration = interval * repeatCount;
        this.t = 0f;
        this.nextTickTime = interval;
        InitBase(duration, onComplete);
    }

    public override void Update(float deltaTime)
    {
        t += deltaTime;
        if (t >= nextTickTime && IsRunning)
        {
            onTick?.Invoke();
            nextTickTime += interval;
        }
        base.Update(deltaTime);
    }

    public override void Recycle()
    {
        base.Recycle();
        this.interval = 0f;
        this.onTick = null;
        this.nextTickTime = 0f;
        this.t = 0f;
    }
}