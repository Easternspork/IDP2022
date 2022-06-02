using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PeterInputCheck : MonoBehaviour
{
    [SerializeField]
    private AudioClip passwordErrorSound;
    public GameObject form;
    public GameObject wrongPass;
    public TMP_InputField inputFieldTMP;
    public GameObject correct;
    public GameObject xButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnEnterPressed()
    {
        if (inputFieldTMP.text.ToLower() == "freg")
        {
            StartCoroutine(ShowThatYouGotCorrect());

            form.SetActive(false);

            GameObject.Find("Fade").GetComponent<Fade>().FadeScene("Fight Scene");
            
            
            Objectives.GetInstance().SetObjective(2);
            GameManager.GetInstance().yardPos = GameObject.Find("Player").transform.position;

            DialogueManager.GetInstance().disableDialogue = true;
            GameManager.GetInstance().disableMovement = true;
        }
        else
        {
            wrongPass.SetActive(true);
            GameObject.Find("Sound").GetComponent<AudioSource>().PlayOneShot(passwordErrorSound);

            TimeManager.GetInstance().AddPenalty(120);
        }
    }

    public void XButton()
    {
        inputFieldTMP.text = "";
        wrongPass.SetActive(false);
        form.SetActive(false);
        DialogueManager.GetInstance().disableDialogue = false;
        GameManager.GetInstance().disableMovement = false;
    }

    IEnumerator ShowThatYouGotCorrect()
    {
        correct.SetActive(true);
        xButton.SetActive(false);
        yield return new WaitForSeconds(3);
    }
}
