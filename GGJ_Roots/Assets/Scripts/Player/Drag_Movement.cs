using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag_Movement : MonoBehaviour
{
    // VARIABLES ---
    public float power = 10f;   // force we add to the object
    public Rigidbody2D rb;

    public Vector2 minPower;
    public Vector2 maxPower;

    LineTrajectory lt;

    Camera cam;
    Vector2 force;
    Vector3 startPoint;
    Vector3 endPoint;

    bool isStill = true;

    private void Start()
    {
        cam = Camera.main;
        lt = GetComponent<LineTrajectory>();
    }

    private void Update()
    {
        // check if player is moving
        if(rb.velocity == new Vector2(0,0))     // if time adjust this
        {
            isStill = true;
        }
        else
        {
            isStill= false;
        }
    }

    private void OnMouseDown()
    {
        if (isStill)
        {
            startPoint = cam.ScreenToWorldPoint(Input.mousePosition);
            startPoint.z = 15;  // ensure that things are visible in the scene
        }
    }

    private void OnMouseDrag()
    {
        // render line when mouse clicks n drags
        if (isStill)
        {
            Vector3 currentPoint = cam.ScreenToWorldPoint(Input.mousePosition);
            currentPoint.z = 15;
            lt.RenderLine(startPoint, currentPoint);
        }
    }

    private void OnMouseUp() 
    {
        if (isStill)
        {
            endPoint = cam.ScreenToWorldPoint(Input.mousePosition);
            endPoint.z = 15;

            force = new Vector2(Mathf.Clamp(startPoint.x - endPoint.x, minPower.x, maxPower.x), Mathf.Clamp(startPoint.y - endPoint.y, minPower.y, maxPower.y));
            rb.AddForce(force * power, ForceMode2D.Impulse);
            lt.EndLine();
        }
    }
}
