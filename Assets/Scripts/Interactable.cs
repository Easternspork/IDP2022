using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Interactable : MonoBehaviour
{
    [SerializeField]
    private GameObject notifier;
    [SerializeField]
    private TextAsset inkJSON;
    [SerializeField]
    private string interactableName;

    private bool inRange;

    private DialogueManager dialogueManager;



    // Start is called before the first frame update
    void Start()
    {
        notifier.SetActive(false);
        inRange = false;
        dialogueManager = DialogueManager.GetInstance();
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && inRange && !dialogueManager.inDialogue)
        {
            OnInteract();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        inRange = true;
        if (collision.gameObject.name == "Player")
        {
            notifier.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        inRange = false;
        notifier.SetActive(false);
    }

    protected virtual void OnInteract()
    {
        dialogueManager.StartDialogue(inkJSON, interactableName);
        
    }
}
