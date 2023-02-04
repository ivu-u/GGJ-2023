using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class MoleSpawn : MonoBehaviour
{

    public int randObj;
    public GameObject Mole;
    public float x;
    public float y;
    public Vector3 originpos;
    public Vector3 distbtwnen;
    public int enemiesperspawn;
    public float enemylife = 0f;
    public float yloc;
    // Start is called before the first frame update
    void Start()
    {
        originpos = transform.position;
        Spawn();
        yloc = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        originpos = transform.position;
        if (enemylife == 0f)
        {
            var r = new Random();
            enemiesperspawn = UnityEngine.Random.Range(3, 6);
            int gap = r.Next(enemiesperspawn);
            for (int column = 0; column < enemiesperspawn; column++)
            {

                // calculate position
                Vector3 spawnPosition = new Vector3(UnityEngine.Random.Range(-11f, 11f), yloc);
                // create new obstacle
                GameObject newEnemy = Instantiate(Mole, spawnPosition, Quaternion.identity);


                Debug.Log("spawned");
            }
            enemylife = 1;
        }
    }
    public void Spawn()
    {

    }
}
