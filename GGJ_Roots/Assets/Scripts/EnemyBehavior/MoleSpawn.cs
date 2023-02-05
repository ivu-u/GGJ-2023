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
    public float countdown = 5f;
    public float yloc;
    public GameObject Camera;
    public DifficultyScript Difficult;
    public float Hardness;
    public Vector3 targetloc;
    GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Player");
        originpos = transform.position;
        Spawn();
        Camera = GameObject.Find("Main Camera");
        Difficult = Camera.GetComponent<DifficultyScript>();
    }

    // Update is called once per frame
    void Update()
    {
        targetloc = target.transform.position;
        Hardness = Difficult.Difficulty;
        originpos = transform.position;
        yloc = transform.position.y;
        if (countdown <= 0f)
        {
            var r = new Random();
            enemiesperspawn = UnityEngine.Random.Range(1, 2);
            int gap = r.Next(enemiesperspawn);
            for (int column = 0; column < enemiesperspawn; column++)
            {

                // calculate position
                Vector3 spawnPosition = new Vector3(UnityEngine.Random.Range(targetloc.x -1, targetloc.x +1), yloc);
                // create new obstacle
                GameObject newEnemy = Instantiate(Mole, spawnPosition, Quaternion.identity);


                Debug.Log("spawned");
            }
            countdown = 5f/Hardness;
        }
        countdown -= Time.deltaTime;
    }
    public void Spawn()
    {

    }
}
