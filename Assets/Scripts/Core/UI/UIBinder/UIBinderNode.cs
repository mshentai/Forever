using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lunar.UI
{
    [Serializable]
    public class UIBinderNode
    {
        public string name;
        public UnityEngine.Object obj;
        public UIElementType type;
        public string reference;
    }
}

