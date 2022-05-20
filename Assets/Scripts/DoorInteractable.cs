using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorInteractable : Interactable
{
    [SerializeField]
    private string changeScene = "Office";

    public bool unlocked = false;

    public override void OnDialogueEnd()
    {
        if (unlocked)
        {
            SceneManager.LoadScene(changeScene);
        }

    }
}
