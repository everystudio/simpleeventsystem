using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private Vector3 m_startPosition;
    private Vector3 m_targetPosition;
    private bool m_bOpen = false;
    public int m_iDoorId;

    private void DoorOpen(int _iDoorId)
    {
        if (m_iDoorId == _iDoorId)
        {
            m_bOpen = true;
        }
    }
    private void DoorClose( int _iDoorId)
    {
        if (m_iDoorId == _iDoorId)
        {
            m_bOpen = false;
        }
    }

    private void Start()
    {
        m_startPosition = transform.position;
        m_targetPosition = transform.position + Vector3.down * 5f;
    }

    private void Update()
    {
        if( m_bOpen)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                m_targetPosition,
                10f * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                m_startPosition,
                10f * Time.deltaTime);
        }
    }

    private void OnEnable()
    {
        DoorEventManager.OnDoorOpen += DoorOpen;
        DoorEventManager.OnDoorClose += DoorClose;
    }
    private void OnDisable()
    {
        DoorEventManager.OnDoorOpen -= DoorOpen;
        DoorEventManager.OnDoorClose -= DoorClose;
    }



}
