﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public Button ContinueButton;
    


    private void Start()
    {
        ContinueButton.interactable = false;
    }


    public void TriggerDialogue ()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);

        ContinueButton.interactable = true;

       
    }
}
