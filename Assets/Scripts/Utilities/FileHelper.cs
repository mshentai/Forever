using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

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
            return Path.GetDirectoryName(path);
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
