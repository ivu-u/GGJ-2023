using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueAudio : MonoBehaviour
{
    private string sceneName;

    private void Awake()
    {
        sceneName = SceneManager.GetActiveScene().name;

        switch (sceneName)
        {
            case "IntroDialogue":
                FindObjectOfType<AudioManager>().Play("SquirrelTheme");
                break;

            case "MantleDialogue":
                FindObjectOfType<AudioManager>().Play("MoleTheme");
                break;
        }
    }
}
