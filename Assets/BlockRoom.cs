using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockRoom : MonoBehaviour
{
    [SerializeField]
    private TextAsset dialogue;

    [SerializeField]
    private List<GameObject> barriers;

    private int barrierNumber = 0;

    private void Start()
    {
        ChangeBarrier();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.collider.name);
        DialogueManager.GetInstance().StartDialogue(dialogue, "You");
    }

    private void ChangeBarrier()
    {
        foreach (GameObject gameObject in barriers)
        {
            gameObject.SetActive(false);
        }

        barriers[barrierNumber].SetActive(true);
        barrierNumber++;
    }
}
