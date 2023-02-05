using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public RockSpawner Rocking;
    public GameObject RockSpawn;
    // Start is called before the first frame update
    void Awake()
    {
        RockSpawn = GameObject.Find("RockSpawner");
        Rocking = RockSpawn.GetComponent<RockSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Rocking.spawntime = 0f;
        Debug.Log("Triggered");
    }
}
