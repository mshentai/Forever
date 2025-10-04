using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lunar.Extensions
{
    public static class ComponentExtension
    {
        public static T GetOrAddComponent<T>(this Component com) where T : Component
        {
            T component = com.GetComponent<T>();
            if (component == null)
            {
                component = com.gameObject.AddComponent<T>();
            }
            return component;
        }
    }
}