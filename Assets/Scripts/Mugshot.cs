using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using TMPro;

public class Mugshot : MonoBehaviour
{
    [SerializeField]
    private List<string> names;

    [SerializeField]
    private List<string> description;

    [SerializeField]
    private List<PlayableDirector> timelines;

    private int characterNumber = 0;

    [SerializeField]
    private TextMeshProUGUI characterName;

    public void ShowNext()
    {
        
        characterNumber++;
    }
    
    public void AskMain()
    {

    }
}
