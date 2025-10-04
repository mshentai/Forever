using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lunar.Event
{
    public static class EventManager
    {
        private readonly static Dictionary<Type, object> eventTable = new Dictionary<Type, object>();

        public static void Subscribe<T>(Action<T> handler) where T : IEventMessage
        {
            var key = typeof(T);
            if (!eventTable.ContainsKey(key))
            {
                var newHandlerList = new List<Action<T>>();
                eventTable.Add(key, newHandlerList);
            }
            var handlers = (List<Action<T>>)eventTable[key];
            if (!handlers.Contains(handler))
            {
                handlers.Add(handler);
            }
            else
            {
                Debug.LogWarning($"Subscribed to the same event repeatedly: {key.ToString()}");
            }
        }

        public static void SubscribeOnce<T>(Action<T> handler) where T : IEventMessage
        {
            if (handler == null) return;

            Action<T> wrappedHandler = null;
            wrappedHandler = (msg) =>
            {
                handler(msg);
                Unsubscribe(wrappedHandler);
            };

            Subscribe(wrappedHandler);
        }

        public static void Unsubscribe<T>(Action<T> handler) where T : IEventMessage
        {
            var key = typeof(T);
            if (eventTable.TryGetValue(key, out var obj))
            {
                var handlers = (List<Action<T>>)obj;
                handlers.Remove(handler);
                if (handlers.Count < 1)
                {
                    eventTable.Remove(key);
                }
            }
            else
            {
                Debug.LogWarning($"Event {key.ToString()} is not exist");
            }
        }

        public static void Trigger<T>(T msg) where T : IEventMessage
        {
            var key = typeof(T);
            if (eventTable.TryGetValue(key, out var obj))
            {
                var handlers = (List<Action<T>>)obj;
                foreach (var handler in handlers.ToArray())
                {
                    if (handler != null)
                    {
                        handler.Invoke(msg);
                    }
                    else
                    {
                        Debug.LogWarning($"Null handler found for event {key}, consider cleaning up subscriptions");
                    }
                }
            }
        }

        public static void Clear<T>() where T : IEventMessage
        {
            eventTable.Remove(typeof(T));
        }

        public static IDisposable SubscribeWithDisposable<T>(Action<T> handler) where T : IEventMessage
        {
            Subscribe(handler);
            return new EventSubscription<T>(handler);
        }
        
        private class EventSubscription<T> : IDisposable where T : IEventMessage
        {
            private Action<T> handler;
            private bool isDisposed = false;

            public EventSubscription(Action<T> handler)
            {
                this.handler = handler;
            }

            public void Dispose()
            {
                if (!isDisposed)
                {
                    EventManager.Unsubscribe(handler);
                    handler = null;
                    isDisposed = true;
                }
            }
        }
    } 
}

