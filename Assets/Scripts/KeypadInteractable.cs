using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadInteractable : Interactable
{
    private bool showing = false;
    private bool interacted = false;
    protected override void Update()
    {
        base.Update();

        // if started dialogue

        if (!DialogueManager.GetInstance().inDialogue && !showing && interacted)
        {
            showing = true;
            Numpad.GetInstance().ShowCanvas();
            DialogueManager.GetInstance().disableDialogue = true;
        }

        // if dialogue ended

        if (!DialogueManager.GetInstance().inDialogue && showing)
        {
            showing = false;
            interacted = false;
        }
    }

    protected override void OnInteract()
    {
        base.OnInteract();
        interacted = true; 
    }
}
