using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public Inventory inventory;
    public GameObject dayCycle;

    public string playerName; 

    public bool disableMovement = false;
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

    public void QuitGame()
    {
        Application.Quit();
    }

    public void HandleSceneChange()
    {
        SceneManager.sceneLoaded += ChangeSceneStartingPos;
    }

    public void ChangeSceneStartingPos(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Cell")
        {
            GameObject.Find("Player").transform.position = new Vector3(10.6f, 28, 0);

        }
        GetComponent<Objectives>().NextObjective();
        SceneManager.sceneLoaded -= ChangeSceneStartingPos;



    }
}
