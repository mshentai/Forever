using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace Lunar
{
    public static class FileTool
    {
        public static bool IsExitFile(string path)
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
    }
}
