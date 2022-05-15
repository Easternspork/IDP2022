using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadInteractable : Interactable
{
    public override void OnDialogueStart()
    {
        base.OnDialogueStart();
        Numpad.GetInstance().ShowCanvas();
        DialogueManager.GetInstance().disableDialogue = true;
    }
}
