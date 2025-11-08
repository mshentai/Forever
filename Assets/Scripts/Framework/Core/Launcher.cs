using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lunar.Core
{
    public class Launcher : MonoBehaviour
    {
        protected void Awake()
        {
            // 初始化数据系统

            // 初始化GameManager
            this.gameObject.AddComponent<GameManager>();
        }
    }
}

