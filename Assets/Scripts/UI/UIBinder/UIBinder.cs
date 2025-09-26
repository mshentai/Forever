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

        public T Get<T>(string name) where T : UnityEngine.Object
        {
            foreach (var node in this.nodes)
            {
                if (node.name == name)
                {
                    if (node.type == UIElementType.Reference)
                    {
                        return (node.obj as GameObject).GetComponent<T>();
                    }
                    else if (node.obj is T t)
                    {
                        return t;
                    }
                }
            }
            return null;
        }
    }
}
