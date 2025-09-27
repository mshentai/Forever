using NUnit.Framework;
using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

namespace Lunar.UI.Tests
{
    public class UIBinderEditorPartTests
    {
        private UIBinder uiBinder;
        private GameObject testGameObject;

        [SetUp]
        public void Setup()
        {
            testGameObject = new GameObject("TestUI");
            uiBinder = testGameObject.AddComponent<UIBinder>();
        }

        [TearDown]
        public void Teardown()
        {
            Object.DestroyImmediate(testGameObject);
        }

        /// <summary>
        /// 测试 BindInternal 方法是否能正确绑定子节点
        /// </summary>
        [Test]
        public void BindInternal_BindsChildrenCorrectly()
        {
            // 创建子节点
            var child1 = new GameObject("Btn_Button1");
            child1.transform.SetParent(testGameObject.transform);
            var child2 = new GameObject("Img_Image1");
            child2.transform.SetParent(testGameObject.transform);

            uiBinder.BindInternal(testGameObject.transform);

            Assert.AreEqual(2, uiBinder.nodes.Count);
            Assert.AreEqual(UIElementType.Button, uiBinder.nodes[0].type);
            Assert.AreEqual(UIElementType.Image, uiBinder.nodes[1].type);
        }

        /// <summary>
        /// 测试 BindInternal 方法是否能正确处理 Reference 类型的节点
        /// </summary>
        [Test]
        public void BindInternal_HandlesReferenceTypeCorrectly()
        {
            var child = new GameObject("Ref_Reference1");
            child.transform.SetParent(testGameObject.transform);

            uiBinder.BindInternal(testGameObject.transform);

            Assert.AreEqual(1, uiBinder.nodes.Count);
            Assert.AreEqual(UIElementType.Reference, uiBinder.nodes[0].type);
            Assert.AreEqual("Reference1", uiBinder.nodes[0].reference);
        }

        /// <summary>
        /// 测试 StrToType 方法是否能正确转换字符串为 UIElementType
        /// </summary>
        [Test]
        public void StrToType_ConvertsStringToUIElementTypeCorrectly()
        {
            Assert.AreEqual(UIElementType.Button, uiBinder.StrToType("Btn"));
            Assert.AreEqual(UIElementType.Image, uiBinder.StrToType("Img"));
            Assert.AreEqual(UIElementType.None, uiBinder.StrToType("Invalid"));
        }

        /// <summary>
        /// 测试 GetObjectByType 方法是否能根据类型返回正确的组件
        /// </summary>
        [Test]
        public void GetObjectByType_ReturnsCorrectComponent()
        {
            var child = new GameObject("TestObject");
            child.AddComponent<UnityEngine.UI.Button>();

            var result = uiBinder.GetObjectByType(child.transform, UIElementType.Button);
            Assert.IsNotNull(result);
            Assert.IsInstanceOf<UnityEngine.UI.Button>(result);
        }

        /// <summary>
        /// 测试 Bind 方法是否能正确绑定并生成 Prefab
        /// </summary>
        [Test]
        public void Bind_CreatesPrefabCorrectly()
        {
            // 模拟 Prefab 路径
            UIBinderSetting.viewPrefabDir = "Assets/Tests/";
            uiBinder.UIName = "TestUI";

            uiBinder.Bind();

            // 验证 Prefab 是否生成
            var prefabPath = "Assets/Tests/TestUI.prefab";
            Assert.IsTrue(System.IO.File.Exists(prefabPath));
        }
    }
}