using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    [SerializeField]
    private GameObject notifier;
    [SerializeField]
    private List<string> dialogue;
    [SerializeField]
    private string interactableName;

    private bool inRange;

    public bool inDialogue;
    
    // Start is called before the first frame update
    void Start()
    {
        notifier.SetActive(false);
        inRange = false;
        inDialogue = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && inRange && !inDialogue)
        {
            Debug.Log("dialogue has started");
            inDialogue = true;
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

}
