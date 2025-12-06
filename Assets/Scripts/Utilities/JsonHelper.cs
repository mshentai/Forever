using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lunar
{
    public static class JsonHelper
    {
        public static T ToObject<T>(string json)
        {
            return JsonUtility.FromJson<T>(json);
        }

        public static string ToJson<T>(T obj)
        {
            return JsonUtility.ToJson(obj);
        }
    }
}

