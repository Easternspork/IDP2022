using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;

public class MethaneMachine : Interactable
{
    [SerializeField]
    private GameObject passwordScreen;

    [SerializeField]
    private string password = "breh";

    [SerializeField]
    private TMP_InputField passwordInput; 

    protected override void OnInteract()
    {
        base.OnInteract();
    }

    public override void OnDialogueEnd()
    {
        base.OnDialogueEnd();
        passwordScreen.SetActive(true);
        DialogueManager.GetInstance().disableDialogue = true;
        GameManager.GetInstance().disableMovement = true;
    }

    public void CheckPassword()
    {
        if (passwordInput.text == password)
        {
            Debug.Log("you win lol");
        } else
        {
            TimeManager.GetInstance().AddPenalty(60);
            Debug.Log("you lose lol LLLLLLLLLLL ratio + ratio + bozo + maidenless + damselless + slept with ur mom + ur sister was watching + i did it with her afterwards + alpha phi");

        }
    }
}
