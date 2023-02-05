using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DifficultyScript : MonoBehaviour
{
    public float Difficulty;
    public int Hard;
    Scene scene;
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        scene = SceneManager.GetActiveScene();
        if(scene.name == "Crust")
        {
            Difficulty = 1f;
            Hard = 1;
        }
        else if(scene.name == "New Mantle")
        {
            Difficulty = 2f;
            Hard = 2;
        }
        else if(scene.name == "Core")
        {
            Difficulty = 3f;
            Hard = 3;
        }
    }
}
