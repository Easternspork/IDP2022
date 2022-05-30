using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using TMPro;
using UnityEngine.SceneManagement;

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

    private void Start()
    {
        
    }


    public void ShowNext()
    {
        Debug.Log("bruh");
        mugshotCanvas.SetActive(true);
        characterName.text = names[characterNumber];
        characterDescription.text = names[characterNumber];

    }
    
    public void AskMain()
    {
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
        GameManager.GetInstance().playerName = inputName.text;
        SceneManager.LoadScene("Cell");
    }
}
