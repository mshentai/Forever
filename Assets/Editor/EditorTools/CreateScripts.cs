using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;

namespace Lunar.EditorTools
{
    public static class CreateScripts
    {
        private readonly static string MonoScriptsTemplatePath = FileHelper.CombinePath(PathDefine.editorPath, "ScriptTemplate/MonoScriptsTemplate.txt");
        private readonly static string NormalScriptsTemplatePath = FileHelper.CombinePath(PathDefine.editorPath, "ScriptTemplate/NormalScriptsTemplate.txt");

        [MenuItem("Assets/Scripts/Create MonoScript", false, 15)]
        public static void CreateMonoScript()
        {
            CreateScript(MonoScriptsTemplatePath, "NewMonoScript");
        }
        [MenuItem("Assets/Scripts/Create NormalScript", false, 16)]
        public static void CreateNormalScript()
        {
            CreateScript(NormalScriptsTemplatePath, "NewNormalScript");
        }
        private static void CreateScript(string templatePath, string defaultName)
        {
            string path = AssetDatabase.GetAssetPath(Selection.activeObject);
            if (FileHelper.IsDirectory(path))
            {
                string relativePath = FileHelper.CombinePath(path, $"{defaultName}.cs");
                var root = PathDefine.editorPath;
                var fullPath = FileHelper.CombinePath(root, relativePath);
                FileHelper.CopyFile(templatePath, fullPath);
                AssetDatabase.Refresh();
                TryRenameScript(relativePath, true);
            }
        }
        [MenuItem("Assets/Scripts/Rename", false, 20)]
        public static void ScriptRename()
        {
            string path = AssetDatabase.GetAssetPath(Selection.activeObject);
            TryRenameScript(path);
        }

        private static void TryRenameScript(string path, bool isModal = false)
        {
            if (path.EndsWith(".cs"))
            {
                string oldFileName = Path.GetFileNameWithoutExtension(path);
                if (isModal)
                {
                    StringInputWindow.ShowModal("请输入新文件名:", "", newFileName => OnRenameInputBack(path, newFileName), null, $"重命名{oldFileName}");
                }
                else
                {
                    StringInputWindow.Show("请输入新文件名:", "", newFileName => OnRenameInputBack(path, newFileName), null, $"重命名{oldFileName}");
                }
            }
            else
            {
                Debug.LogError("请选择一个cs文件");
            }
        }

        private static void OnRenameInputBack(string oldPath, string newFileName)
        {
            if (string.IsNullOrWhiteSpace(newFileName)) return;
            string oldFileName = FileHelper.GetFileName(oldPath);
            string content = FileHelper.ReadAllText(oldPath).Replace(oldFileName, newFileName);
            FileHelper.WriteAllText(oldPath, content);
            var result = AssetDatabase.RenameAsset(oldPath, newFileName);
            Debug.Assert(result == newFileName, "RenameAsset failed");
            AssetDatabase.Refresh();
        }
    }
}