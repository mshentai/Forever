using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lunar
{
    public class CoroutineManager : MonoBehaviour
    {
        private static CoroutineManager _instance;
        public static CoroutineManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    var go = new GameObject("CoroutineManager");
                    DontDestroyOnLoad(go);
                    _instance = go.AddComponent<CoroutineManager>();
                }
                return _instance;
            }
        }

        private Dictionary<string, Coroutine> coroutineDict = new Dictionary<string, Coroutine>();

        // 启动协程并用 key 标记
        public Coroutine StartManagedCoroutine(IEnumerator routine, string key = null)
        {
            if (!string.IsNullOrEmpty(key) && coroutineDict.ContainsKey(key))
            {
                StopCoroutine(coroutineDict[key]);
                coroutineDict.Remove(key);
            }
            Coroutine co = StartCoroutine(RunCoroutine(routine, key));
            if (!string.IsNullOrEmpty(key))
                coroutineDict.Add(key, co);
            return co;
        }

        private IEnumerator RunCoroutine(IEnumerator routine, string key)
        {
            yield return routine;
            if (!string.IsNullOrEmpty(key))
                coroutineDict.Remove(key);
        }

        // 停止指定 key 的协程
        public void StopManagedCoroutine(string key)
        {
            if (coroutineDict.ContainsKey(key))
            {
                StopCoroutine(coroutineDict[key]);
                coroutineDict.Remove(key);
            }
        }

        // 停止所有协程
        public void StopAllManagedCoroutines()
        {
            foreach (var co in coroutineDict.Values)
                StopCoroutine(co);
            coroutineDict.Clear();
        }
    }
}