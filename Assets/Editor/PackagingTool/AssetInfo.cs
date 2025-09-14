using System.Collections;
using System.Collections.Generic;
using UnityEditor;

namespace Lunar.Building
{
    public class AssetInfo
    {
        public string AssetPath { get; set; }
        public bool IsCollectAsset { get; set; }
        public bool IsSceneAsset { get; set; }
        public bool IsVideoAsset { get; set; }

        public int DependCount { get; set; } = 0;
        public string AssetBuildLabel { get; set; } = null;
        public string AssetBundleVariant { get; set; } = null;
        public string ReadableLabel { get; set; } = null;
        public BundleType BundleType { get; set; }

        public AssetInfo(string assetPath)
        {
            AssetPath = assetPath;
            IsCollectAsset = CollectionHandle.IsCollectAsset(assetPath);
            var assetType = AssetDatabase.GetMainAssetTypeAtPath(assetPath);
            IsSceneAsset = assetType == typeof(SceneAsset);
            IsVideoAsset = assetType == typeof(UnityEngine.Video.VideoClip);
        }

    }
}
