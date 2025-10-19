using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Lunar.UI
{
    public class MainView : MainViewGen
    {
        public struct Evt : Core.IEventMessage
        {
            public string msg;
        }
        public struct Evt2 : Core.IEventMessage
        {
            public string msg;
        }
        protected override void OnAddEvent()
        {
            base.OnAddEvent();
            this.AddEvent<Evt>(this.OnEvt);
            this.AddEvent<Evt2>(this.OnEvt);
        }

        private void OnEvt(Evt e)
        {
            Debug.LogError(e.msg);
        }
        private void OnEvt(Evt2 e)
        {
            Debug.LogError(e.msg);
        }
    }
}