using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lunar.Utilities
{
    public class Singleton<T> where T : new()
    {
        private static T _instance;
        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new T();
                }
                return _instance;
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