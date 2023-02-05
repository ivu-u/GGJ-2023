using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float ms = 6;

    private bool didPress = false;

    public Rigidbody2D rb;

    private void FixedUpdate()
    {
        if(rb.velocity.magnitude > 0) 
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
