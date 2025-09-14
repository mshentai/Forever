using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;

namespace Lunar.Building {
    [Serializable]
    public class Wrapper
    {
        public string DirPath = string.Empty;
        public PackRule PackRule = PackRule.Collect;
        public LabelRule LabelRule = LabelRule.LabelByFilePath;
        public BundleType BundleType = BundleType.BuildIn;
    }

    [Serializable]
    public enum PackRule
    {
        Collect,
        Ignore,
        Passive,
    }

    [Serializable]
    public enum LabelRule
    {
        LabelByFilePath,
        LabelByFileName,
        LabelByDirPath,
        LabelByDirName,
    }

    [Serializable]
    public enum BundleType
    {
        BuildIn,
        InGame,
    }
}
