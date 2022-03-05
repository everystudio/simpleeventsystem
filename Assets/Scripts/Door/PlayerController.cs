using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Update()
    {
        float fInputHorizontal = Input.GetAxisRaw("Horizontal");
        transform.Translate(fInputHorizontal * 3f * Time.deltaTime, 0f, 0f);
        if( 0 < fInputHorizontal)
        {
            transform.localScale = Vector3.one;
        }
        else if(fInputHorizontal < 0)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else { }
    }
}
