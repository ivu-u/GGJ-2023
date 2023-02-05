using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSounds : MonoBehaviour
{
    public void playButtonHover()
    {
        FindObjectOfType<AudioManager>().Play("ButtonHover");
    }

    public void playButtonClick()
    {
        FindObjectOfType<AudioManager>().Play("ButtonClick");
    }
}
