using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StagingScript : MonoBehaviour
{
    public Vector3 startloc;
    public Vector3 currentloc;
    public float winloc = 50f;
    public float distance;
    public GameObject Manager;
    public DifficultyScript Difficult;
    public float level = 1f;
    // Start is called before the first frame update
    void Awake()
    {
        startloc = transform.position;
        Manager = GameObject.Find("Manager");
        Difficult = Manager.GetComponent<DifficultyScript>();
    }

    // Update is called once per frame
    void Update()
    {
        currentloc = transform.position;
        distance = startloc.y - currentloc.y;
        if(distance >= winloc)
        {
            Difficult.Difficulty += 1f;
            Difficult.Hard += 1;
            level += 1;
            Debug.Log("Level change");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
