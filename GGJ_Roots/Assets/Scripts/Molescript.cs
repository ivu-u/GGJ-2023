using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Molescript : MonoBehaviour
{
    public float Molespeed;
    GameObject Target;
    public Vector3 targetloc;
    public Vector3 director;
    public Quaternion rotator;
    public float Rotatespeed;
    // Start is called before the first frame update
    void Start()
    {
        Target = GameObject.Find("NerdEmoji");
        Molespeed = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        targetloc = Target.transform.position;
        if (targetloc.y > transform.position.y)
        {
            director = (targetloc - transform.position);
            rotator = Quaternion.LookRotation(director);
            rotator.x = 0;
            rotator.y = 0;
            rotator.z = rotator.z * -1;
            transform.rotation = Quaternion.RotateTowards(transform.rotation, rotator, Rotatespeed);
            transform.position += (transform.up * Molespeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(0f, Molespeed * Time.deltaTime, 0f);
        }
    }
}
