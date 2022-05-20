using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Ink.Runtime;
using Ink.UnityIntegration;

public class DialogueManager : MonoBehaviour
{
    public bool disableDialogue = false;
    public bool inDialogue;
    private static DialogueManager instance = null;

    [SerializeField]
    protected GameObject dialogueCanvas;
    [SerializeField]
    protected TextMeshProUGUI dialogueName;
    [SerializeField]
    protected TextMeshProUGUI dialogueContent;

    private Story currentStory;

    protected Interactable interactableInstance = null;

    [SerializeField] private GameObject[] choices;

    private TextMeshProUGUI[] choicesText;

    private DialogueVariables dialogueVariables;

    [SerializeField]
    private InkFile globalInkFile;

    // Start is called before the first frame update
    protected DialogueManager() {}

    private void Start()
    {
        inDialogue = false;
        if (instance != null)
        {
            Debug.LogWarning("Two instances of dialogueManger");
        }
        instance = this;
        HideCanvas();

        choicesText = new TextMeshProUGUI[choices.Length];
        for (int i = 0; i<choices.Length; i++)
        {
            choicesText[i] = choices[i].GetComponentInChildren<TextMeshProUGUI>();
        }

        dialogueVariables = new DialogueVariables(globalInkFile.filePath);
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

    public void StartDialogue(Interactable interactableInstance)
    {

        this.interactableInstance = interactableInstance;

        if (disableDialogue == false)
        {
            dialogueName.text = this.interactableInstance.interactableName;

            currentStory = new Story(this.interactableInstance.inkJSON.text);
            inDialogue = true;
            ShowCanvas();
            SetInkVariables();

            //dialogueVariables.StartListening(currentStory);

            if (currentStory.canContinue)
            {
                dialogueContent.text = currentStory.Continue();
            }
            else
            {
                StartCoroutine(ExitDialogue());
            }
        }


        this.interactableInstance.OnDialogueStart();
        DisplayChoices();

    }

    public void StartDialogue(TextAsset inkJSON, string name)
    {

        if (disableDialogue == false)
        {
            dialogueName.text = name;

            currentStory = new Story(inkJSON.text);
            inDialogue = true;
            ShowCanvas();

            //dialogueVariables.StartListening(currentStory);
            SetInkVariables();

            if (currentStory.canContinue)
            {
                dialogueContent.text = currentStory.Continue();

            }
            else
            {
                StartCoroutine(ExitDialogue());
            }
        }

        DisplayChoices();

    }

    public void NextDialogue()
    {
        if (currentStory.canContinue)
        {
            dialogueContent.text = currentStory.Continue();
            DisplayChoices();
        }
        else
        {
            StartCoroutine(ExitDialogue());
        }
    }

    private IEnumerator ExitDialogue()
    {
        yield return new WaitForSeconds(0.2f);

        //dialogueVariables.StopListening(currentStory);

        inDialogue = false;
        GameManager.GetInstance().disableMovement = false;
        HideCanvas();
        dialogueContent.text = "";

        if (this.interactableInstance != null)
        {
            this.interactableInstance.OnDialogueEnd();
        }

        this.interactableInstance = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (!inDialogue)
        {
            return;
        }

        // make sure that you can't continue when there is dialogue selection

        if (currentStory.currentChoices.Count == 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                NextDialogue();
            }
        }

    }

    private void DisplayChoices()
    {

        List<Choice> currentChoices = currentStory.currentChoices;

        if (currentChoices.Count > choices.Length)
        {
            Debug.LogError("More choices than buttons");
        }

        int index = 0;

        foreach (Choice choice in currentChoices)
        {
            choices[index].gameObject.SetActive(true);
            choicesText[index].text = choice.text;
            index++;
        }

        for (int i = index; i < choices.Length; i++)
        {
            choices[i].gameObject.SetActive(false);

        }
    }

    public void MakeChoice(int choiceIndex)
    {
        currentStory.ChooseChoiceIndex(choiceIndex);
        NextDialogue();
    }

    public void SetInkVariables()
    {
        currentStory.variablesState["hasShrimp"] = Inventory.GetInstance().GetItemList().Contains("Shrimp");
        currentStory.variablesState["officeOpen"] = Inventory.GetInstance().GetItemList().Contains("Key");

    }
}
