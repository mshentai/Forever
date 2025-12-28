using System.Collections.Generic;
using Lunar.Core;
using UnityEngine;
using System;
using System.Linq;

namespace Lunar.Core
{
    public class TimerGroup
    {
        private TimerManager mgr => TimerManager.Instance;
        private Dictionary<string, ITimer> timers = new();
        public void SetTimeout(string name, float delay, Action callback)
        {
            if (timers.ContainsKey(name))
            {
                this.ClearTimeout(name);
            }
            var timer = mgr.AddTimer(delay, callback);
            timers.Add(name, timer);
        }

        public void SetInterval(string name, float interval, int repeatCount, Action callback)
        {
            if (timers.ContainsKey(name))
            {
                this.ClearInterval(name);
            }
            var timer = mgr.AddLoopTimer(interval, repeatCount, callback);
            timers.Add(name, timer);
        }

        public void ClearTimeout(string name)
        {
            this.ClearTimer(name);
        }

        public void ClearInterval(string name)
        {
            this.ClearTimer(name);
        }

        private void ClearTimer(string name)
        {
            if (timers.ContainsKey(name))
            {
                var timer = timers[name];
                mgr.RemoveTimer(timer);
                timers.Remove(name);
            }
        }

        public void ClearAll()
        {
            var keys = timers.Keys.ToList();
            foreach (var key in keys)
            {
                this.ClearTimer(key);
            }
        }
    }
}