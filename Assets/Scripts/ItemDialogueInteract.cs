using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDialogueInteract : Interactable
{
    [SerializeField]
    private Item giveItem;

    protected override void OnInteract()
    {
        base.OnInteract();
        if (!GameManager.GetInstance().inventory.items.Contains(giveItem))
        {
            GameManager.GetInstance().inventory.items.Add(giveItem);
            Debug.Log("gave item");
        }
    }
}
