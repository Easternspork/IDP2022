using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotebookInteractable : Interactable
{
    [SerializeField]
    private GameObject notebook;

    // Start is called before the first frame update
    void Start()
    {
        notebook.SetActive(false);
    }

    protected override void OnInteract()
    {
        base.OnInteract();
        DialogueManager.GetInstance().disableDialogue = true;
        GameManager.GetInstance().disableMovement = true;
    }

}
