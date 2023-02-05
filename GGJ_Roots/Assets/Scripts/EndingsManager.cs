using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingsManager : MonoBehaviour
{
    Player player;
    void Start()
    {
        player = gameObject.GetComponent<Player>();
    }
    void Update()
    {
        // bad ending
        if (player.currentWater <= 0)
        {
            SceneManager.LoadScene(4);
        }
        // good ending 
        /*if ()
        {
            SceneManager.LoadScene(5);
        }*/
    }
}
