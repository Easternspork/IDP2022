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
        Debug.Log((bool)DialogueManager.GetInstance().currentStory.variablesState["guessWindow"] == true);

            
        if ((bool)DialogueManager.GetInstance().currentStory.variablesState["guessWindow"] == true && (bool)DialogueManager.GetInstance().currentStory.variablesState["beaten"] == false)
        {
            Debug.Log("hudiswad");
            input.SetActive(true);
            DialogueManager.GetInstance().disableDialogue = true;
            GameManager.GetInstance().disableMovement = true;
        }
        else if ((bool)DialogueManager.GetInstance().currentStory.variablesState["guessWindow"] == false)
        {
            input.SetActive(false);

        }
    }

    protected override void Update()
    {
        base.Update();
    }

}
