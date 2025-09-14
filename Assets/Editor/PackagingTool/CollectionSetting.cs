using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

namespace Lunar.Building
{
    [CreateAssetMenu]
    public class CollectionSetting : ScriptableObject
    {
        [SerializeField]
        public List<Wrapper> elements = new List<Wrapper>();
    }
}
