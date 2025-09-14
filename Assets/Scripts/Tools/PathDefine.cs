using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lunar
{
    public static class PathDefine
    {
        public static string collectionSettingPath = "Assets/Editor/CollectionSetting.asset";
        public static string bundlePath = "Assets/Bundles";
        public static string manifestPath = "Manifest.txt";
        public static string bundleLoadPathFormat = Application.streamingAssetsPath + "/{0}.bundle";
    }
}