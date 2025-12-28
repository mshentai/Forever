using System.Collections;
using System.Collections.Generic;
using Lunar.Utilities;
using UnityEngine;

namespace Lunar.Core
{
    public class GameManager : SingletonMonoBehaviour<GameManager>
    {

        private void Update()
        {
            TickManager.Instance.Update();
            TimerManager.Instance.Update();
        }
    }
}

