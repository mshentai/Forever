using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

namespace Lunar.Building
{
    [CreateAssetMenu(fileName = "CollectionSetting", menuName = "CollectionSetting", order = 1000)]
    public class CollectionSetting : ScriptableObject
    {
        [SerializeField]
        public List<Wrapper> elements = new List<Wrapper>();
    }
}
