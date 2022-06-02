using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPeterInputOK : MonoBehaviour
{
    public GameObject input;

    // Start is called before the first frame update
    void Start()
    {
        input.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (DialogueManager.GetInstance().inDialogue)
        {
            if ((bool)DialogueManager.GetInstance().currentStory.variablesState["guessWindow"] == true)
            {
                input.SetActive(true);
            }
            else if ((bool)DialogueManager.GetInstance().currentStory.variablesState["guessWindow"] == false)
            {
                input.SetActive(false);

            }
        }
    }
}
