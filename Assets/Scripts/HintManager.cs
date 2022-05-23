using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintManager : MonoBehaviour
{
    public TextAsset inkJSON;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnHintButtonPressed()
    {
        DialogueManager.GetInstance().StartDialogue(inkJSON, "Hint");
    }
}
