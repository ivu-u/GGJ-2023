using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float ms = 6;

    private bool didPress = false;

    private void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * ms * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.DownArrow)) 
        { 
            didPress= true;
        }
    }

    private void Update()
    {
        if(didPress) 
        {
            transform.Translate(Vector3.down * ms * Time.deltaTime);
        }
    }
}
