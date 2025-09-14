using System.IO;
using UnityEngine;

namespace Forever.Tool
{
    public class FileHelp
    {
        public static string DataPath => Application.dataPath;

        public static string GetDir(string path)
        {
            FileInfo fi = new FileInfo(path);
            return fi.DirectoryName;
        }

        public static bool IsExistFile(string filePath)
        {
            return File.Exists(filePath);
        }

    }

}