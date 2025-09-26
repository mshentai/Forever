#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Lunar.UI
{
    public partial class UIBinder : MonoBehaviour
    {
        public void Bind()
        {
            this.nodes.Clear();
            this.UIName = this.gameObject.name;
            this.BindInternal(this.transform);
        }

        private void BindInternal(Transform node)
        {
            for (int i = 0; i < node.childCount; ++i)
            {
                var child = node.GetChild(0);
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
                this.BindInternal(child);
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

        public void GenerateScript()
        {
            var scriptTp = AssetDatabase.LoadAssetAtPath<TextAsset>(UIBinderSetting.scriptTpPath);
            Debug.LogError(scriptTp.ToString());
        }
    }
}
#endif