using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lunar.Building
{
    public class AssetNode
    {
        public string Name { get; set; }
        public string MD5 { get; set; }
        public string[] Dependencies { get; set; }

        public AssetNode(string name, string md5, string[] depends)
        {
            this.Name = name;
            this.MD5 = md5;
            this.Dependencies = depends;
        }
    }
}
