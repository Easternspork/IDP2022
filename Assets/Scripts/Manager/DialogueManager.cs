using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Ink.Runtime;

public class DialogueManager : MonoBehaviour
{
    public bool inDialogue;
    private static DialogueManager instance = null;

    [SerializeField]
    public GameObject dialogueCanvas;
    [SerializeField]
    private TextMeshProUGUI dialogueName;
    [SerializeField]
    private TextMeshProUGUI dialogueContent;

    private Story currentStory;

    // Start is called before the first frame update
    protected DialogueManager() {}

    private void Start()
    {
        inDialogue = false;
        if (instance != null)
        {
            Debug.Log("Two instances of dialogueManger");
        }
        instance = this;
        HideCanvas();
    }

    public static DialogueManager GetInstance()
    {
        // fix this cuz im not allowed to use new keyword here
        return instance;
    }

    public void ShowCanvas()
    {
        dialogueCanvas.SetActive(true);   
    }

    public void HideCanvas()
    {
        dialogueCanvas.SetActive(false);
    }

    public void StartDialogue(TextAsset inkJSON, string name)
    {
        dialogueName.text = name;

        currentStory = new Story(inkJSON.text);
        inDialogue = true;
        ShowCanvas();

        if (currentStory.canContinue)
        {
            dialogueContent.text = currentStory.Continue();
        } else
        {
            ExitDialogue();
        }
    }
    public void NextDialogue()
    {
        if (currentStory.canContinue)
        {
            dialogueContent.text = currentStory.Continue();
        }
        else
        {
            StartCoroutine(ExitDialogue());
        }
    }

    private IEnumerator ExitDialogue()
    {
        yield return new WaitForSeconds(0.2f);
        inDialogue = false;
        HideCanvas();
        dialogueContent.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (!inDialogue)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            NextDialogue();
        }
    }
}
