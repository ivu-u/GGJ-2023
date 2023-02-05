using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class RockSpawner : MonoBehaviour
{

    public int randObj;
    public GameObject Rock;
    public float x;
    public float y;
    public Vector3 originpos;
    public Vector3 distbtwnen;
    public int enemiesperspawn;
    public float spawntime = 1f;
    public float yloc;
    public float xloc;
    public GameObject Manager;
    public DifficultyScript Difficult;
    public int Hardness;
    public GameObject Camera;
    // Start is called before the first frame update
    void Start()
    {
        originpos = transform.position;
        Spawn();
        Manager = GameObject.Find("DifficultyManager");
        Difficult = Manager.GetComponent<DifficultyScript>();
        Camera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        Hardness = Difficult.Hard;
        xloc = transform.position.x;
        yloc = transform.position.y;
        Transform Cameraloc = Camera.transform;
        originpos = transform.position;
        if (spawntime == 0f)
        {
            var r = new Random();
            enemiesperspawn = UnityEngine.Random.Range(5, 9);
            int gap = r.Next(enemiesperspawn);
            for (int column = 0; column < enemiesperspawn; column++)
            {

                // calculate position
                Vector3 spawnPosition = new Vector3(UnityEngine.Random.Range(xloc, -xloc), UnityEngine.Random.Range(yloc-1f, yloc-11));
                // create new obstacle
                GameObject newEnemy = Instantiate(Rock, spawnPosition, Quaternion.identity);


                Debug.Log("spawned");
            }
            spawntime = 1f;
        }
    }
    public void Spawn()
    {

    }
}