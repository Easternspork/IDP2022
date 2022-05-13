using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public List<string> items;
    private static GameManager instance;

    private void Start()
    {
        if (instance != null)
        {
            Debug.LogWarning("Two instances of GameManager");
        }
        instance = this;
    }
    public static GameManager GetInstance()
    {
        // fix this cuz im not allowed to use new keyword here
        return instance;
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Cell");
        TimeManager.GetInstance().StartTimer();
    }
}
