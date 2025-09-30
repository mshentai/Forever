#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using Lunar.Extensions;

namespace Lunar.UI
{
    public partial class UIBinder : MonoBehaviour
    {
        public bool overwriteIfExist = true;
        public void Bind()
        {
            this.nodes.Clear();
            this.UIName = this.GetUIName();
            this.BindInternal(this.transform);
            this.CreatePrefab();
        }

        private string GetUIName()
        {
            var fullName = this.gameObject.name;
            if (fullName.Contains("_"))
            {
                var parts = fullName.Split('_');
                if (parts.Length > 1)
                {
                    return parts[1];
                }
            }
            return fullName;
        }

        private void BindInternal(Transform node)
        {
            for (int i = 0; i < node.childCount; ++i)
            {
                var child = node.GetChild(i);
                var fullName = child.name;
                var args = fullName.Split('_');
                var typeStr = args[0];
                var type = this.StrToType(typeStr);
                if (type != UIElementType.None)
                {
                    var obj = this.GetObjectByType(child, type);
                    var binderNode = new UIBinderNode
                    {
                        name = fullName,
                        type = type,
                        obj = obj,
                        reference = type == UIElementType.Reference ? args[1] : null,
                    };
                    this.nodes.Add(binderNode);
                }
                if (type != UIElementType.Reference)
                {
                    this.BindInternal(child);
                }
                else
                {
                    if (!PrefabUtility.IsPartOfAnyPrefab(child.gameObject))
                    {
                        child.gameObject.GetOrAddComponent<UIBinder>().Bind();
                    }
                }
            }
        }

        private UIElementType StrToType(string typeStr)
        {
            return typeStr switch
            {
                "Btn" => UIElementType.Button,
                "Img" => UIElementType.Image,
                "Txt" => UIElementType.Text,
                "RawImg" => UIElementType.RawImage,
                "Toggle" => UIElementType.Toggle,
                "Slider" => UIElementType.Slider,
                "Input" => UIElementType.InputField,
                "Scroll" => UIElementType.ScrollRect,
                "Go" => UIElementType.GameObject,
                "Trans" => UIElementType.Transform,
                "Ref" => UIElementType.Reference,
                _ => UIElementType.None,
            };
        }

        private UnityEngine.Object GetObjectByType(Transform node, UIElementType type)
        {
            return type switch
            {
                UIElementType.Button => node.GetComponent<UnityEngine.UI.Button>(),
                UIElementType.Image => node.GetComponent<UnityEngine.UI.Image>(),
                UIElementType.Text => node.GetComponent<UnityEngine.UI.Text>(),
                UIElementType.RawImage => node.GetComponent<UnityEngine.UI.RawImage>(),
                UIElementType.Toggle => node.GetComponent<UnityEngine.UI.Toggle>(),
                UIElementType.Slider => node.GetComponent<UnityEngine.UI.Slider>(),
                UIElementType.InputField => node.GetComponent<UnityEngine.UI.InputField>(),
                UIElementType.ScrollRect => node.GetComponent<UnityEngine.UI.ScrollRect>(),
                UIElementType.GameObject => node.gameObject,
                UIElementType.Transform => node,
                UIElementType.Reference => node.gameObject,
                _ => null,
            };
        }

        private void CreatePrefab()
        {
            string path;
            string fileName = this.UIName + ".prefab";
            if (this.UIType == UIType.Component)
            {
                path = UIBinderSetting.comPrefabDir + fileName;
            }
            else
            {
                path = UIBinderSetting.viewPrefabDir + fileName;
            }
            if (!FileTool.IsExitFile(path) || this.overwriteIfExist)
            {
                if (PrefabUtility.IsAnyPrefabInstanceRoot(this.gameObject))
                {
                    PrefabUtility.UnpackPrefabInstance(this.gameObject, PrefabUnpackMode.OutermostRoot, InteractionMode.AutomatedAction);
                }
                PrefabUtility.SaveAsPrefabAssetAndConnect(this.gameObject, path, InteractionMode.AutomatedAction, out bool success);
                if (success)
                {
                    AssetDatabase.SaveAssets();
                    AssetDatabase.Refresh();
                    Debug.Log($"{this.UIName} is saved as PrefabAsset, path is {path}");
                }
                else
                {
                    Debug.LogError("save as PrefabAsset failed");
                }
            }
        }

        public void GenerateScript()
        {
            this.GenerateGenTpFile();
            this.GenerateScriptFile();
        }

        public void GenerateGenTpFile()
        {
            var scriptTp = File.ReadAllText(UIBinderSetting.genTpPath);
            var content = "";
            var savePath = UIBinderSetting.scriptDir + this.UIName + ".cs";
        }

        public void GenerateScriptFile()
        {
            
        }
    }
}
#endif