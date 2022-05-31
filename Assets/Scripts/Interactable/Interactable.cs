using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class Interactable : MonoBehaviour
{
    [SerializeField]
    protected GameObject notifier;

    public TextAsset inkJSON;

    private bool inRange;

    // Start is called before the first frame update
    void Start()
    {
        notifier.SetActive(false);
        inRange = false;
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && inRange && !DialogueManager.GetInstance().inDialogue)
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

        DialogueManager.GetInstance().StartDialogue(inkJSON);
    }

    public virtual void OnDialogueStart()
    {

    }

    public virtual void OnDialogueEnd()
    {

    }
}
