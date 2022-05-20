using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadInteractable : Interactable
{
    protected override void OnInteract()
    {
        base.OnInteract();
    }

    public override void OnDialogueEnd()
    {
        base.OnDialogueEnd();
        Numpad.GetInstance().ShowCanvas();
        DialogueManager.GetInstance().disableDialogue = true;
        DialogueManager.GetInstance().inDialogue = true;

    }
}
