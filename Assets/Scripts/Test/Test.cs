using System.Collections;
using System.Collections.Generic;
using Lunar.Core;
using Lunar.UI;
using UnityEngine;

public class Test : MonoBehaviour
{
    void OnGUI()
    {
        if (GUILayout.Button("1"))
        {
            EventManager.Trigger(new MainView.Evt()
            {
                msg = "evt1",
            });
        }
        if (GUILayout.Button("2"))
        {
            EventManager.Trigger(new MainView.Evt2()
            {
                msg = "evt2",
            });
        }
    }
}
