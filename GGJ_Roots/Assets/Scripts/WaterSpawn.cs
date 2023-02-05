using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class WaterSpawn : MonoBehaviour
{

    public int randObj;
    public GameObject Water;
    public float x;
    public float y;
    public Vector3 originpos;
    public Vector3 distbtwnen;
    public int enemiesperspawn;
    public float spawntime = 1f;
    public float yloc;
    public float xloc;
    public GameObject Camera;
    // Start is called before the first frame update
    void Start()
    {
        originpos = transform.position;
        Spawn();
        Camera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        xloc = transform.position.x;
        yloc = transform.position.y;
        Transform Cameraloc = Camera.transform;
        originpos = transform.position;
        if (spawntime == 0f)
        {
            var r = new Random();
            enemiesperspawn = UnityEngine.Random.Range(1, 3);
            int gap = r.Next(enemiesperspawn);
            for (int column = 0; column < enemiesperspawn; column++)
            {

                // calculate position
                Vector3 spawnPosition = new Vector3(UnityEngine.Random.Range(xloc, -xloc), UnityEngine.Random.Range(yloc - 1f, yloc - 11));
                // create new obstacle
                GameObject newEnemy = Instantiate(Water, spawnPosition, Quaternion.identity);


                Debug.Log("spawned water");
            }
            spawntime = 1f;
        }
    }
    public void Spawn()
    {

    }
}
