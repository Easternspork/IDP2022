using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadInteractable : Interactable
{
    protected override void OnInteract()
    {
        if (Numpad.GetInstance().openedDoor == false)
        base.OnInteract();
    }

    public override void OnDialogueEnd()
    {
        base.OnDialogueEnd();
        Numpad.GetInstance().ShowCanvas();
        //DialogueManager.GetInstance().disableDialogue = true;
        GameManager.GetInstance().disableMovement = true;
        DialogueManager.GetInstance().disableDialogue = true;

    }
}
