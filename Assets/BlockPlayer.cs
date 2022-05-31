using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockPlayer : MonoBehaviour
{

    [SerializeField]
    private TextAsset inkJSON;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        DialogueManager.GetInstance().StartDialogue(inkJSON);
    }
}
