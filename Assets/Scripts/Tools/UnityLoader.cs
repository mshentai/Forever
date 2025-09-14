using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Forever.Tool;

namespace Forever.GameFrame
{
    public class UnityLoader : Puerts.ILoader, Puerts.IModuleChecker
    {
        private readonly string root;
        public UnityLoader()
        {
            this.root = FileHelp.GetDir(FileHelp.DataPath).Replace("\\", "/") + "/TSProject/Output/";
        }
        public bool FileExists(string filepath)
        {
            filepath = this.GetRealPath(filepath);
            return FileHelp.IsExistFile(filepath);
        }

        public bool IsESM(string filepath)
        {
            return true;
        }

        public string ReadFile(string filepath, out string debugpath)
        {
            debugpath = filepath;
            filepath = this.GetRealPath(filepath);
            return System.IO.File.ReadAllText(filepath);
        }

        private string GetRealPath(string filepath)
        {
            if (filepath.EndsWith("js"))
            {
                return this.root + filepath;
            } 
            else
            {
                return $"{this.root}{filepath}.js";
            }
        }
    }
}
