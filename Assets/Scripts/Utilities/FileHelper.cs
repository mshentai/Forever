using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Data.Common;

namespace Lunar
{
    public static class FileHelper
    {
        public static bool IsExistFile(string path)
        {
            return File.Exists(path);
        }

        public static void CreateDirByFilePath(string filePath)
        {
            var dirPath = Path.GetDirectoryName(filePath);
            CreateDirByDirPath(dirPath);
        }

        public static string GetFileName(string path)
        {
            return Path.GetFileNameWithoutExtension(path);
        }

        public static string GetDirPath(string path)
        {
            return Path.GetDirectoryName(path).Replace("\\", "/");
        }

        public static string CombinePath(string path1, string path2)
        {
            return Path.Combine(path1, path2).Replace("\\", "/");
        }

        public static bool IsDirectory(string path)
        {
            return Directory.Exists(path);
        }

        public static void CopyFile(string srcPath, string destPath)
        {
            if (IsExistFile(srcPath) && !IsExistFile(destPath))
            {
                CreateDirByFilePath(destPath);
                File.Copy(srcPath, destPath);
            }
        }

        public static void CreateDirByDirPath(string dirPath)
        {
            if (dirPath != string.Empty && !Directory.Exists(dirPath))
            {
                var parentDirPath = Path.GetDirectoryName(dirPath);
                CreateDirByDirPath(parentDirPath);
                Directory.CreateDirectory(dirPath);
            }
        }

        public static string ReadAllText(string path)
        {
            if (IsExistFile(path))
            {
                return File.ReadAllText(path);
            }
            return string.Empty;
        }

        public static void WriteAllText(string path, string content)
        {
            CreateDirByFilePath(path);
            File.WriteAllText(path, content);
        }
    }
}
