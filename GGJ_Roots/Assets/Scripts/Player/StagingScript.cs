using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StagingScript : MonoBehaviour
{
    public Vector3 startloc;
    public Vector3 currentloc;
    public float winloc = 50f;
    public float distance;
    public GameObject Camera;
    public DifficultyScript Difficult;
    // Start is called before the first frame update
    void Awake()
    {
        startloc = transform.position;
        Camera = GameObject.Find("Main Camera");
        Difficult = Camera.GetComponent<DifficultyScript>();
    }

    // Update is called once per frame
    void Update()
    {
        currentloc = transform.position;
        distance = startloc.y - currentloc.y;
        if(distance == winloc)
        {
            Difficult.Difficulty += 1f;
            Difficult.Hard += 1;
            Debug.Log("Level change");
        }
    }
}
