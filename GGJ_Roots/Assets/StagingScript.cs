using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StagingScript : MonoBehaviour
{
    public Vector3 startloc;
    public Vector3 currentloc;
    public float winloc = 50f;
    public float distance;
    // Start is called before the first frame update
    void Start()
    {
        startloc = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        currentloc = transform.position;
        distance = startloc.y - currentloc.y;
        if(distance == winloc)
        {
            Debug.Log("Level change");
        }
    }
}
