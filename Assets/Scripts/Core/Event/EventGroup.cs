using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Lunar.Event
{
    public class EventGroup
    {
        private readonly Dictionary<Type, IDisposable> subscriptions = new();

        public void AddEvent<T>(Action<T> handler) where T : IEventMessage
        {
            var key = typeof(T);
            if (subscriptions.ContainsKey(key))
            {
                Debug.LogWarning($"Replacing existing subscription for {key}");
                this.RemoveEvent(key);
            }
            var subscription = EventManager.SubscribeWithDisposable(handler);
            subscriptions.Add(key, subscription);
        }

        public void RemoveEvent<T>() where T : IEventMessage
        {
            var key = typeof(T);
            if (subscriptions.ContainsKey(key))
            {
                RemoveEvent(key);
            }
        }

        private void RemoveEvent(Type type)
        {
            if (subscriptions.TryGetValue(type, out var disposable))
            {
                disposable.Dispose();
                subscriptions.Remove(type);
            }
        }

        public void Clear()
        {
            foreach (var t in subscriptions.Keys.ToArray())
            {
                RemoveEvent(t);
            }
        }

        ~EventGroup()
        {
            this.Clear();
        }
    }
}
