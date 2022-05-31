using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintManager : MonoBehaviour
{
    public TextAsset[] hintInks;
    public int currentPuzzle = 0;
    // Start is called before the first frame update
    private static HintManager instance; 

    void Start()
    {
        if (instance != null)
        {
            Debug.LogWarning("Two instances of dialogueManger");
        }
        instance = this;
    }

    public static HintManager GetInstance()
    {
        return instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnHintButtonPressed()
    {
        DialogueManager.GetInstance().StartDialogue(hintInks[currentPuzzle]);
    }


    public void setPuzzleHint(int n)
    { 
        currentPuzzle = n;
    }
}
