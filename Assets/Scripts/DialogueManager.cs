using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

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

    // Start is called before the first frame update
    protected DialogueManager() {}

    private void Start()
    {
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
        dialogueCanvas.SetActive(true);
    }

    public void StartDialogue(string name, List<string> dialogueList)
    {
        Debug.Log("dialogue has started");
        inDialogue = true;
        ShowCanvas();

        //change 

        dialogueName.text = name;
        dialogueContent.text = dialogueList[0];
        NextDialogue(dialogueList);
    }

    public void NextDialogue(List<string> dialogueList)
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
