using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockRoom : MonoBehaviour
{
    [SerializeField]
    private TextAsset dialogue;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.collider.name);
        DialogueManager.GetInstance().StartDialogue(dialogue, "You");
    }
}
