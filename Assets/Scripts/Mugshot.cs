using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using TMPro;
using UnityEngine.SceneManagement;
using Ink.Runtime;

public class Mugshot : MonoBehaviour
{
    [SerializeField]
    private List<string> names;

    [SerializeField]
    private List<string> description;

    [SerializeField]
    private List<PlayableDirector> timelines;


    [SerializeField]
    private List<PlayableDirector> timelinesOut;

    private int characterNumber = 0;

    [SerializeField]
    private TextMeshProUGUI characterName;

    [SerializeField]
    private TextMeshProUGUI characterDescription;

    [SerializeField]
    private GameObject inputField;

    [SerializeField]
    private TMP_InputField inputName;
    
    [SerializeField]
    private GameObject nextButton;

    [SerializeField]
    private GameObject mugshotCanvas;

    [SerializeField]
    private GameObject descriptionThing;
    
    [SerializeField]
    private GameObject nameThing;

    public TextAsset randomInkJSON;

    private void Start()
    {
        
    }


    public void ShowNext()
    {
        Debug.Log("bruh");
        mugshotCanvas.SetActive(true);
        characterName.text = names[characterNumber];
        characterDescription.text = description[characterNumber];

    }
    
    public void AskMain()
    {
        characterName.text = "";
        characterDescription.text = "";
        nextButton.SetActive(false);
        mugshotCanvas.SetActive(true);
        inputField.SetActive(true);
    }

    public void OnNextPressed()
    {

        mugshotCanvas.SetActive(false);
        timelinesOut[characterNumber].Play();
        characterNumber++;
        timelines[characterNumber].Play();
        

    }

    public void OnEnterPressed()
    {
        if (inputName.text != "")
        {
            GameManager.GetInstance().playerName = inputName.text;
            Story globalInk = new Story(randomInkJSON.text);
            DialogueManager.GetInstance().dialogueVariables.StartListening(globalInk);
            globalInk.variablesState["mc"] = inputName.text;
            DialogueManager.GetInstance().dialogueVariables.StopListening(globalInk);
            SceneManager.LoadScene("Cell");
             //SceneManager.LoadScene("Igloo Scene");
            Objectives.GetInstance().ShowButton();
            TimeManager.GetInstance().StartTimer();
        }

    }
}
