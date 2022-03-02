using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSize : MonoBehaviour
{
    void Start()
    {
        EventManager.ExampleEvent += IncreaseSize;
    }

    private void IncreaseSize()
    {
        transform.localScale = new Vector3(2, 2, 2);
    }
}
