using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    private int count = 0;

    public void TriggerDialogue()
    {
        if(count== 0)
        {
            Debug.Log("start");
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            count++;
        }
        else
        {
            FindObjectOfType<DialogueManager>().DisplayNextSentence();
        }
    }
}
