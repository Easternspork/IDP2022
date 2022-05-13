using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDialogueInteract : Interactable
{
    [SerializeField]
    private string giveItem;

    protected override void OnInteract()
    {
        base.OnInteract();
        if (!GameManager.GetInstance().items.Contains(giveItem))
        {
            GameManager.GetInstance().items.Add(giveItem);
            Debug.Log("gave item");
        }
    }
}
