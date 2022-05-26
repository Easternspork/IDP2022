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

    [SerializeField]
    private AudioClip doorOpenSound;

    public override void OnDialogueEnd()
    {
        if (Inventory.GetInstance().GetItemList().Contains("Key"))
        {
            GameObject.Find("Sound").GetComponent<AudioSource>().PlayOneShot(doorOpenSound);
            SceneManager.LoadScene(changeScene);
        }

    }
}
