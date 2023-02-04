using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testmove : MonoBehaviour
{
    public float speed = 9f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rightleft = 0;
        float updown = 0;

        if (Input.GetKey(KeyCode.A)) rightleft += -1;
        if (Input.GetKey(KeyCode.D)) rightleft += 1;
        if (Input.GetKey(KeyCode.W)) updown += 1;
        if (Input.GetKey(KeyCode.S)) updown += -1;

        rightleft *= speed;
        updown *= speed;

        rightleft *= Time.deltaTime;
        updown *= Time.deltaTime;
        transform.Translate(rightleft, updown, 0);
    }
}
