using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class WormSpawn : MonoBehaviour
{

    public int randObj;
    public GameObject Worm;
    public float x;
    public float y;
    public Vector3 originpos;
    public Vector3 distbtwnen;
    public int enemiesperspawn;
    public float countdown = 0f;
    public float yloc;
    public Vector3 targetloc;
    GameObject target;
    GameObject[] nospawn;
    Vector3 nospawnloc;
    public int xloc;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("NerdEmoji");
        originpos = transform.position;
        Spawn();
        yloc = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        nospawn = GameObject.FindGameObjectsWithTag("Rock");
        foreach(GameObject Rock in nospawn)
        {
            nospawnloc = new Vector3(Rock.transform.position.x, Rock.transform.position.y, 0f);
        }
        originpos = transform.position;
        targetloc = target.transform.position;
        if (countdown <= 0f)
        {
            var r = new Random();
            enemiesperspawn = UnityEngine.Random.Range(1,2);
            int gap = r.Next(enemiesperspawn);
            for (int column = 0; column < enemiesperspawn; column++)
            {

                // calculate position
                xloc = UnityEngine.Random.Range(1, 2);
                if (xloc == 2)
                {
                    xloc = -1;
                }
                Vector3 spawnPosition = new Vector3(transform.position.x * xloc, UnityEngine.Random.Range(yloc+.5f, targetloc.y-.5f));
                if (spawnPosition.y == nospawnloc.y)
                {
                    spawnPosition = new Vector3(transform.position.x, UnityEngine.Random.Range(yloc + .5f, targetloc.y - .5f));
                }
                else
                {
                    // create new obstacle
                    if (xloc == 1)
                    {
                        GameObject newEnemy = Instantiate(Worm, spawnPosition, Quaternion.identity);
                        Debug.Log("spawned");
                    }
                    if (xloc == -1)
                    {
                        GameObject newEnemy = Instantiate(Worm, spawnPosition, Quaternion.Inverse(Quaternion.identity));
                        Debug.Log("spawned");
                    }
                }
                countdown = 10f;
            }
        }
        countdown -= Time.deltaTime;
    }
    public void Spawn()
    {

    }
}
