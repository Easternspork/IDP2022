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
        SceneManager.LoadScene("Nighttime");
    }
    public void GoToPrison()
    {
        SceneManager.LoadScene("Mug Shot");
    }
}
