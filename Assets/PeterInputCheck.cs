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
            GameManager.GetInstance().yardPos = GameObject.Find("Player").transform.position;
        }
        else
        {
            wrongPass.SetActive(true);
            GameObject.Find("Sound").GetComponent<AudioSource>().PlayOneShot(passwordErrorSound);

            TimeManager.GetInstance().AddPenalty(120);
        }
    }

    IEnumerator ShowThatYouGotCorrect()
    {
        correct.SetActive(true);
        yield return new WaitForSeconds(3);
    }
}
