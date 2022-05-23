using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotebookInteractable : Interactable
{
    [SerializeField]
    private GameObject notebook;
    public override void OnDialogueEnd()
    {
        ShowPuzzle();
        base.OnDialogueEnd();
        DialogueManager.GetInstance().disableDialogue = true;
        GameManager.GetInstance().disableMovement = true;
    }

    protected override void OnInteract()
    {
        base.OnInteract();
    }

    public void ShowPuzzle()
    {
        notebook.SetActive(true);
    }
    public void HidePuzzle()
    {
        notebook.SetActive(false);
        GameManager.GetInstance().disableMovement = false;
        DialogueManager.GetInstance().disableDialogue = false;

    }

    private void Start()
    {
        HidePuzzle();
    }

}
