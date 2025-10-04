using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Lunar.UI
{
    public class MainViewGen: UIBase
    {
        public UIBinder binder;
        protected void Awake()
        {
            this.binder = this.GetComponent<UIBinder>();
        }

        public GameObject Go_Root => this.binder.Get<GameObject>("Go_Root");
        public Image Img_A => this.binder.Get<Image>("Img_A");
        public Text Txt_B => this.binder.Get<Text>("Txt_B");
    }
}

