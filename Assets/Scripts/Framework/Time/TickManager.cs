using System.Collections.Generic;
using Lunar.Core;
using Lunar.Utilities;
using UnityEngine;

namespace Lunar.Core
{
    public class TickManager : Singleton<TickManager>
    {
        private readonly List<ITickable> tickables = new();
        public void Register(ITickable tickable)
        {
            if (!tickables.Contains(tickable))
            {
                tickables.Add(tickable);
            }
        }

        public void Register<T>(T tickable) where T : ITickable, new()
        {
            if (!tickables.Contains(tickable))
            {
                tickables.Add(tickable);
            }
            else
            {
                LLog.Error($"Tickable {tickable} is already registered");
            }
        }

        public void Unregister(ITickable tickable)
        {
            if (tickables.Contains(tickable))
            {
                tickables.Remove(tickable);
            }
            else
            {
                Debug.LogError($"Tickable {tickable} is not registered");
            }
        }

        public void Update()
        {
            foreach (var tickable in tickables)
            {
                tickable.Update();
            }
        }
    }
}