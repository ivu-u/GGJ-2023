using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wormscript : MonoBehaviour
{
    public float Wormspeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Wormspeed * Time.deltaTime, 0f, 0f);
    }
}
