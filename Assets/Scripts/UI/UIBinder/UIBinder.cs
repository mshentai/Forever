using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lunar.UI
{
    [ExecuteAlways]
    public partial class UIBinder : MonoBehaviour
    {
        public string UIName;
        public UIType UIType = UIType.Panel;
        public List<UIBinderNode> nodes = new List<UIBinderNode>();
        private Dictionary<string, UnityEngine.Object> _cache;
        private Dictionary<string, UnityEngine.Object> Cache
        {
            get
            {
                if (_cache == null)
                {
                    _cache = new Dictionary<string, UnityEngine.Object>();
                    foreach (var node in this.nodes)
                    {
                        _cache.Add(node.name, node.obj);
                    }
                }
                return _cache;
            }
        } 

        public T Get<T>(string name) where T : UnityEngine.Object
        {
            T ans = null;
            if (Cache.TryGetValue(name, out var com))
            {
                if (com is T t)
                {
                    ans = t;
                }
                else
                {
                    ans = (com as GameObject).GetComponent<T>();
                    Cache[name] = ans;
                }
            }
            return ans;
        }
    }
}
