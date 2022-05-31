using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellDoor : Interactable
{
    [SerializeField]
    private AudioClip doorOpenSound;
    
    public override void OnDialogueEnd()
    {
        base.OnDialogueEnd();
        if (Inventory.GetInstance().GetItemList().Contains("Hairpin"))
        {
            Destroy(gameObject);
            GameObject.Find("Sound").GetComponent<AudioSource>().PlayOneShot(doorOpenSound);

        }
    }
}
