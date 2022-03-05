using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DoorEventManager : MonoBehaviour
{
    public static event Action<int> OnDoorOpen;
    public static event Action<int> OnDoorClose;

    public static void DoorOpen(int _iDoorId)
    {
        OnDoorOpen?.Invoke(_iDoorId);
    }
    public static void DoorClose(int _iDoorId)
    {
        OnDoorClose?.Invoke(_iDoorId);
    }
}
