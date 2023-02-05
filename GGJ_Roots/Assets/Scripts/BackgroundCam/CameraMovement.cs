using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraMovement : MonoBehaviour
{
    public float ms = 0;

    private bool didStart = false;

    public Rigidbody2D rb;

    private string sceneName;

    private void Awake()
    {
        sceneName = SceneManager.GetActiveScene().name;

        switch (sceneName)
        {
            case "Crust":
                //FindObjectOfType<AudioManager>().Stop();
                FindObjectOfType<AudioManager>().Play("CrustTheme");
                break;

            case "New Mantle":
                //FindObjectOfType<AudioManager>().Stop();
                FindObjectOfType<AudioManager>().Play("MantleTheme");
                break;

            case "Core":
                //FindObjectOfType<AudioManager>().Stop();
                FindObjectOfType<AudioManager>().Play("CoreTheme");
                break;
            default:
                //FindObjectOfType<AudioManager>().Stop();
                break;
        }
    }


    private void FixedUpdate()
    {
        if(rb.velocity.magnitude > 0) 
        { 
            didStart= true;
        }
    }

    private void Update()
    {
        if(didStart) 
        {
            switch(sceneName)
            {
                case "Crust":
                    ms = 1;
                    break;

                case "Mantle":
                    ms = 1.5f;
                    break;

                case "Core":
                    ms = 2;
                    break;
            }

            transform.Translate(Vector3.down * ms * Time.deltaTime);
        }
    }
}
