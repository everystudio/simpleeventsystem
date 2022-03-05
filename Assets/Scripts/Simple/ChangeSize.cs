using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSize : MonoBehaviour
{
    private void OnEnable()
    {
        EventManager.ExampleEvent += IncreaseSize;
    }
    private void OnDisable()
    {
        EventManager.ExampleEvent -= IncreaseSize;
    }
    private void IncreaseSize()
    {
        Debug.Log("Called.IncreaseSize");
        transform.localScale = new Vector3(2, 2, 2);
    }
}
