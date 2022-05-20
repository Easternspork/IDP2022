using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Ink.Runtime;

public class DoorInteractable : Interactable
{
    [SerializeField]
    private string changeScene = "Office";

    public bool unlocked = false;

    public override void OnDialogueEnd()
    {
        if (Inventory.GetInstance().GetItemList().Contains("Key"))
        {
            SceneManager.LoadScene(changeScene);
        }

    }
}
