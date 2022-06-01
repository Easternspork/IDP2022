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
            StartCoroutine(MoveToYard());
        }

        bool beaten = (bool)DialogueManager.GetInstance().currentStory.variablesState["beaten"];

        if (beaten == true && !GameManager.GetInstance().fightHappened)
        {
            GameManager.GetInstance().fightHappened = true;
            GameObject.Find("Fade").GetComponent<Fade>().FadeScene("Fight Scene");
            GameManager.GetInstance().yardPos = GameObject.Find("Player").transform.position;
            Destroy(this);
        }

        bool hairpin = (bool)DialogueManager.GetInstance().currentStory.variablesState["hairpin"];
        bool officeOpen = (bool)DialogueManager.GetInstance().currentStory.variablesState["officeOpen"];

        if (officeOpen && !GameManager.GetInstance().gaveKey)
        {
            GameManager.GetInstance().gaveKey = true;
            Inventory.GetInstance().AddItem("Key");
        }

        if (hairpin && officeOpen && !GameManager.GetInstance().nightHappened)
        {
            GameManager.GetInstance().nightHappened = true;
            GameObject.Find("Fade").GetComponent<Fade>().FadeScene("Nighttime");
            TimeManager.GetInstance().puzzle1Time = TimeManager.GetInstance().timer;

        }

        bool hasShrimp = (bool)DialogueManager.GetInstance().currentStory.variablesState["hasShrimp"];

        if (hasShrimp && !Inventory.GetInstance().GetItemList().Contains("Shrimp"))
        {
            Inventory.GetInstance().AddItem("Shrimp");
        }
    }

    IEnumerator MoveToYard()
    {

        GameManager.GetInstance().breakfastEndedOnce = true;
        GameManager.GetInstance().cellPos = GameObject.Find("Player").transform.position;

        GameObject.Find("Fade").GetComponent<Fade>().FadeScene("Yard");
        yield return new WaitForSeconds(1);
        DialogueManager.GetInstance().StartDialogue(DialogueManager.GetInstance().yardTransitionInkJSON);
        DialogueManager.GetInstance().currentStory.variablesState["breakFast"] = false;
        
    }
}
