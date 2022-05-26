using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Numpad : MonoBehaviour
{
    private string input = "";
    private const string password = "06837";

    [SerializeField]
    private TextMeshProUGUI inputText;

    [SerializeField]
    private GameObject canvas;

    [SerializeField]
    private int penaltyTime = 30;

    private static Numpad instance;

    [SerializeField]
    private AudioClip numpadSound;
    
    private void Start()
    {
        if (instance != null)
        {
            Debug.LogWarning("Two instances of Numpad");
        }
        instance = this;

        HideCanvas();
    }
    public static Numpad GetInstance()
    {
        // fix this cuz im not allowed to use new keyword here
        return instance;
    }

    // Update is called once per frame
    void Update()
    {
        if (input.Length > 5)
        {
            BackSpace();
            // TODO: possibly call an invalid sound effect here
        }
    }

    public void ShowCanvas()
    {
        canvas.SetActive(true);

    }

    public void HideCanvas()
    {
        canvas.SetActive(false);
        DialogueManager.GetInstance().disableDialogue = false;
        DialogueManager.GetInstance().inDialogue = false;
        GameManager.GetInstance().disableMovement = false; 
    }

    public void UpdateText()
    {
        inputText.text = input;
        // bad practice but like whatever
        GameObject.Find("Sound").GetComponent<AudioSource>().PlayOneShot(numpadSound);

    }

    public void Zero()
    {
        input += "0";
        UpdateText();
    }

    public void One()
    {
        input += "1";
        UpdateText();
    }

    public void Two()
    {
        input += "2";
        UpdateText();

    }

    public void Three()
    {
        input += "3";
        UpdateText();

    }

    public void Four()
    {
        input += "4";
        UpdateText();

    }

    public void Five()
    {
        input += "5";
        UpdateText();

    }

    public void Six()
    {
        input += "6";
        UpdateText();

    }

    public void Seven()
    {
        input += "7";
        UpdateText();

    }

    public void Eight()
    {
        input += "8";
        UpdateText();

    }

    public void Nine()
    {
        input += "9";
        UpdateText();

    }

    public void BackSpace()
    {
        input = input.Remove(input.Length - 1, 1);
        UpdateText();

    }

    public void Enter()
    {
        // TODO: actually put stuff here

        if (input == password)
        {
            Debug.Log("you win!");
            HideCanvas();
        } else
        {
            Debug.Log("you suck");
            TimeManager.GetInstance().AddPenalty(penaltyTime);
            HideCanvas();
        }

        input = "";
        UpdateText();

        GameManager.GetInstance().disableMovement = false;
        DialogueManager.GetInstance().disableDialogue = false; 
    }
}
