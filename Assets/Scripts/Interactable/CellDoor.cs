using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellDoor : Interactable
{
    [SerializeField]
    private AudioClip doorOpenSound;
    
    public override void OnDialogueEnd()
    {
        Debug.Log(Inventory.GetInstance().GetItemList().Contains("Hairpin"));

        base.OnDialogueEnd();
        if (Inventory.GetInstance().GetItemList().Contains("Hairpin"))
        {
            Debug.Log("rueiahi0");
            GameObject.Find("Sound").GetComponent<AudioSource>().PlayOneShot(doorOpenSound);
            Destroy(gameObject);


        }
    }
}
