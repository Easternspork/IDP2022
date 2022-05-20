using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotebookInteractable : Interactable
{
    [SerializeField]
    private GameObject notebook;
    public override void OnDialogueEnd()
    {
        base.OnDialogueEnd();
        Numpad.GetInstance().ShowCanvas();
        DialogueManager.GetInstance().disableDialogue = true;
        GameManager.GetInstance().disableMovement = true;
    }

    protected override void OnInteract()
    {
        base.OnInteract();
        ShowPuzzle();
    }

    public void ShowPuzzle()
    {
        notebook.SetActive(true);
    }
    public void HidePuzzle()
    {
        notebook.SetActive(false);
    }

    private void Start()
    {
        HidePuzzle();
    }
}
