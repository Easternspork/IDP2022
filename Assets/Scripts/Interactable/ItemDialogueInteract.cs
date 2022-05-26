using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDialogueInteract : Interactable
{
    [SerializeField]
    private string giveItem;

    [SerializeField]
    private bool destoryAfter = false;

    protected override void OnInteract()
    {
        base.OnInteract();
        if (!Inventory.GetInstance().GetItemList().Contains(giveItem))
        {
            Inventory.GetInstance().AddItem(giveItem);
            Debug.Log("gave item");
        }
    }

    public override void OnDialogueEnd()
    {
        base.OnDialogueEnd();
        if (destoryAfter)
        {
            Destroy(gameObject);
        }
    }

    protected override void Update()
    {
        if (Inventory.GetInstance().GetItemList().Contains(giveItem))
        {
            Destroy(gameObject);
        }
        base.Update();

    }
}
