using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Puerts;
using System.Linq;

public class Test : MonoBehaviour
{
    private void Start()
    {

        var loader = new Lunar.Resource.ABLoader();
        //Assets/ResLib/Cube, 7F47BB4E0EBE9E0240732149DB18EB6A
        var prefab = loader.Load("Assets/ResLib/Cube") as GameObject;
        Instantiate(prefab);
    }
}
