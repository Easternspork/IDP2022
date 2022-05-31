using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using TMPro;

public class ComputerInteractable : Interactable
{
    [SerializeField]
    private AudioClip passwordErrorSound;
    [SerializeField]
    private GameObject computerScreen;
    [SerializeField]
    private GameObject passwordScreen;
    [SerializeField]
    private GameObject desktopCanvas;
    [SerializeField]
    private GameObject passwordTab;

    [SerializeField]
    private TMP_InputField inputField;

    [SerializeField]
    private string password = "when the well is dry, we know the worth of water";

    [SerializeField]
    private GameObject passwordWrong;

    protected override void Update()
    {
        base.Update();
        
    }
    protected override void OnInteract()
    {
        ShowComputer();
    }

    public void ShowComputer()
    {
        computerScreen.SetActive(true);
        Objectives.GetInstance().HideObjectivesButton();
    }

    public void HideComputer()
    {
        computerScreen.SetActive(false);
        passwordTab.SetActive(false);
        passwordScreen.SetActive(true);
        Objectives.GetInstance().HideObjectivesButton();
    }

    public void HidePasswordScreen()
    {
        passwordScreen.SetActive(false);
    }

    public void ShowDesktop()
    {
        desktopCanvas.SetActive(true);

    }

    public void HideDesktop()
    {
        desktopCanvas.SetActive(false);

    }

    public void ShowTab()
    {
        passwordTab.SetActive(true);
    }


    public void CheckPassword()
    {
        if (inputField.text.ToLower() == password)
        {
            HidePasswordScreen();
            ShowDesktop();
            passwordWrong.SetActive(false);
            TimeManager.GetInstance().puzzle2Time = TimeManager.GetInstance().timer;


        }
        else
        {
            TimeManager.GetInstance().AddPenalty(60 * 2);

            passwordWrong.SetActive(true);

            // add "wrong" sound
            GameObject.Find("Sound").GetComponent<AudioSource>().PlayOneShot(passwordErrorSound);
        }
    }


}
