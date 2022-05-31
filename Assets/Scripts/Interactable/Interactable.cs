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

        DialogueManager.GetInstance().StartDialogue(this);
    }

    public virtual void OnDialogueStart()
    {

    }

    public virtual void OnDialogueEnd()
    {
        bool breakfastOver =
               (bool)DialogueManager.GetInstance().currentStory.variablesState["b1"] == true &&
               (bool)DialogueManager.GetInstance().currentStory.variablesState["b2"] == true &&
               (bool)DialogueManager.GetInstance().currentStory.variablesState["b3"] == true &&
               (bool)DialogueManager.GetInstance().currentStory.variablesState["b4"] == true &&
               (bool)DialogueManager.GetInstance().currentStory.variablesState["b5"] == true &&
               (bool)DialogueManager.GetInstance().currentStory.variablesState["b6"] == true;


        if (breakfastOver == true && !GameManager.GetInstance().breakfastEndedOnce)
        {
            GameManager.GetInstance().breakfastEndedOnce = true;

            GameObject.Find("Fade").GetComponent<Fade>().FadeScene("Yard");
            GameManager.GetInstance().cellPos = GameObject.Find("Player").transform.position;
            GameManager.GetInstance().HandleSceneChange();
            DialogueManager.GetInstance().StartDialogue(DialogueManager.GetInstance().yardTransitionInkJSON);
            DialogueManager.GetInstance().currentStory.variablesState["breakFast"] = false;
        }

        bool beaten = (bool)DialogueManager.GetInstance().currentStory.variablesState["beaten"];

        if (beaten == true && !GameManager.GetInstance().fightHappened)
        {
            GameManager.GetInstance().fightHappened = true;
            GameObject.Find("Fade").GetComponent<Fade>().FadeScene("Fight Scene");


        }
    }
}
