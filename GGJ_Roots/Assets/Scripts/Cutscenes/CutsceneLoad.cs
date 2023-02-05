using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneLoad : MonoBehaviour
{
    private float time = 0f;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > 24f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
