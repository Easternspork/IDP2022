using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransToNight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToNight()
    {
        
        Objectives.GetInstance().SetObjective(3);
        SceneManager.LoadScene("Nighttime");
        HintManager.GetInstance().setPuzzleHint(1);
    }
    public void GoToPrison()
    {
        SceneManager.LoadScene("Mug Shot");
        
        Objectives.GetInstance().SetObjective(0);
    }
}
