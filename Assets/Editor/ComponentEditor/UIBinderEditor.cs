using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Lunar.UI
{
    [CustomEditor(typeof(UIBinder))]
    public class UIBinderEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            if (GUILayout.Button("Bind", GUILayout.Height(30)))
            {
                var binder = this.target as UIBinder;
                binder.Bind();
            }
            if (GUILayout.Button("GenerateScript", GUILayout.Height(30)))
            {
                var binder = this.target as UIBinder;
                binder.GenerateScript();
            }
        }
    }
}

