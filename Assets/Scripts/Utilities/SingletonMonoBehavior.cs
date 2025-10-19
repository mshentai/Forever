using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lunar.Utilities
{
    public class SingletonMonoBehaviour<T> : MonoBehaviour where T : Component
    {

        private static T _instance;

        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = FindFirstObjectByType(typeof(T)) as T;
                    if (_instance == null)
                    {
                        _instance = new GameObject(nameof(T)).AddComponent<T>();
                    }
                    DontDestroyOnLoad(_instance.gameObject);
                }
                return _instance;
            }
        }

        protected void Awake()
        {
            if (_instance == null)
            {
                _instance = this as T;
            }
        }
    }
}