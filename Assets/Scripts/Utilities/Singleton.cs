using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lunar.Utilities
{
    public class Singleton<T> where T : class, new()
    {
        private readonly static Lazy<T> _instance = new(() => new T());
        public static T Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        protected Singleton()
        {
            this.OnInit();
        }

        protected virtual void OnInit()
        {

        }

        protected virtual void OnReset()
        {

        }
    }
}