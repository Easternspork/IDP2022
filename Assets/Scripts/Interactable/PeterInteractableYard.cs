using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PeterInteractableYard : Interactable
{
    public GameObject input;
    public override void OnDialogueEnd()
    {
        base.OnDialogueEnd();
        if ((bool)DialogueManager.GetInstance().currentStory.variablesState["guessWindow"] == true)
        {
            input.SetActive(true);
        }
        else if ((bool)DialogueManager.GetInstance().currentStory.variablesState["guessWindow"] == false)
        {
            input.SetActive(false);

        }
    }

    protected override void Update()
    {
        base.Update();
        Debug.Log((bool)DialogueManager.GetInstance().currentStory.variablesState["guessWindow"] == true);
    }

}
