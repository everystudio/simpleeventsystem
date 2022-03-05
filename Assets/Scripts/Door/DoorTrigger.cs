using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public int m_iDoorId;

    private void OnTriggerEnter2D(Collider2D _collision)
    {
        DoorEventManager.DoorOpen(m_iDoorId);
    }
    private void OnTriggerExit2D(Collider2D _collision)
    {
        DoorEventManager.DoorClose(m_iDoorId);
    }

}
