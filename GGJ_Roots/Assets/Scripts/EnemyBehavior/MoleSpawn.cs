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
    public float countdown = 0f;
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
        if (countdown <= 0f)
        {
            var r = new Random();
            enemiesperspawn = UnityEngine.Random.Range(1, 2);
            int gap = r.Next(enemiesperspawn);
            for (int column = 0; column < enemiesperspawn; column++)
            {

                // calculate position
                Vector3 spawnPosition = new Vector3(UnityEngine.Random.Range(-8.5f, 8.5f), yloc);
                // create new obstacle
                GameObject newEnemy = Instantiate(Mole, spawnPosition, Quaternion.identity);


                Debug.Log("spawned");
            }
            countdown = 10f;
        }
        countdown -= Time.deltaTime;
    }
    public void Spawn()
    {

    }
}
