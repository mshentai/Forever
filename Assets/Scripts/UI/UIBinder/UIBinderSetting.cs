#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lunar.UI
{
    public static class UIBinderSetting
    {
        public static string genTpPath = "ScriptTemplate/GenTemplate.txt";
        public static string scriptTpPath = "ScriptTemplate/ScriptTemplate.txt";
        public static string scriptDir = "Assets/Scripts/UI/";
        public static string viewPrefabDir = "Assets/ResLib/Prefab/UI/";
        public static string comPrefabDir = "Assets/ResLib/Prefab/UI/Component/";
    }
}
#endif