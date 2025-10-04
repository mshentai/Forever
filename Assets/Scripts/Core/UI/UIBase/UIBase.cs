using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lunar.UI
{
    public class UIBase : MonoBehaviour
    {
        public UIState state = UIState.None;
        private readonly Event.EventGroup eventGroup = new Event.EventGroup();

        protected virtual void OnInit()
        {

        }

        protected virtual void OnAddEvent()
        {

        }

        protected virtual void OnRemoveEvent()
        {
            this.eventGroup.Clear();
        }

        protected void AddEvent<T>(Action<T> handler) where T : Event.IEventMessage
        {
            this.eventGroup.AddEvent(handler);
        }

        protected virtual void OnShow()
        {

        }

        protected virtual void OnHide()
        {

        }

        protected virtual void OnDispose()
        {

        }

        protected void OnEnable()
        {
            if (this.state != UIState.None)
            {
                this.OnAddEvent();
                this.OnShow();
                this.state = UIState.Show;
            }
        }

        protected void OnDisable()
        {
            if (this.state != UIState.None)
            {
                this.OnHide();
                this.OnRemoveEvent();
                this.state = UIState.Hide;
            }
        }

        protected void Start()
        {
            this.OnInit();
            this.OnAddEvent();
            this.OnShow();
            this.state = UIState.Show;
        }

        protected void OnDestroy()
        {
            this.state = UIState.Dispose;
            this.OnDispose();
        }

        public void SetActvie(bool isActive)
        {
            if (isActive != this.gameObject.activeSelf)
            {
                this.gameObject.SetActive(isActive);
            }
        }
    }
}

