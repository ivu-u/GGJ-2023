using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform target;

    public Transform bckg1;
    public Transform bckg2;
    public Transform bckg_first;

    private float size;

    private void Start()
    {
        size = bckg1.GetComponent<BoxCollider2D>().size.y;
    }

    void FixedUpdate()
    {
        // camera
        Vector3 targetPos = new Vector3(target.position.x, target.position.y, transform.position.z);
        transform.position = targetPos;

        transform.position = Vector3.Lerp(transform.position, targetPos, 0.2f);

        // background
        if(transform.position.y >= bckg2.position.y)
        {
            bckg1.position = new Vector3(bckg1.position.x, bckg2.position.y + size, bckg1.position.z);
            SwitchBckg();
        }

        if(transform.position.y < bckg1.position.y) 
        { 
            bckg2.position = new Vector3(bckg2.position.x, bckg1.position.y - size, bckg2.position.z);
            SwitchBckg();
        }
    }

    private void SwitchBckg()
    {
        Transform temp = bckg1;
        bckg1 = bckg2;
        bckg2 = temp;
    }
}
