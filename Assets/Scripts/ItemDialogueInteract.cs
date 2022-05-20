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
        if (!Inventory.GetInstance().GetItemList().Contains(giveItem))
        {
            Inventory.GetInstance().AddItem(giveItem);
            Debug.Log("gave item");
        }
    }
}
