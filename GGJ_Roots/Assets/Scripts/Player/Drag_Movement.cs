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

    Camera cam;
    Vector2 force;
    Vector3 startPoint;
    Vector3 endPoint;

    private void Start()
    {
        cam = Camera.main;
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0)) 
        {
            startPoint.z = 15;  // ensure that things are visible in the scene
            startPoint = cam.ScreenToWorldPoint(Input.mousePosition);
        }

        if(Input.GetMouseButtonUp(0)) 
        { 
            endPoint.z = 15;
            endPoint = cam.ScreenToWorldPoint(Input.mousePosition);

            force = new Vector2(Mathf.Clamp(startPoint.x - endPoint.x, minPower.x, maxPower.x), Mathf.Clamp(startPoint.y - endPoint.y, minPower.y, maxPower.y));
            rb.AddForce(force * power, ForceMode2D.Impulse);
        }
    }
}
