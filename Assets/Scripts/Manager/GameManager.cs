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

    public Vector3 cellPos;

    public bool breakfastEndedOnce = false;
    public bool fightHappened;

    public Vector3 yardPos;
    public bool nightHappened;
    public bool gaveKey;

    public bool firstTimeNightTime = true;

    private void Awake()
    {
        SceneManager.sceneLoaded += ChangeSceneStartingPos;
    }

    private void Start()
    {
        if (instance != null)
        {
            Debug.LogWarning("Two instances of GameManager");
        }
        instance = this;
        Objectives.GetInstance().SetObjective(0);
    }

    public static GameManager GetInstance()
    {
        // fix this cuz im not allowed to use new keyword here
        return instance;
    }

    public void StartGame()
    {

        // change later
        SceneManager.LoadScene("Cell");

    }

    public void QuitGame()
    {
        Application.Quit();
    }

    //scuffed 
    public void ChangeSceneStartingPos(Scene scene, LoadSceneMode mode)
    {
        

        //if (scene.name == "Nighttime" && !firstTimeNightTime)
        //{
        //    Debug.Log("scene pos changed");
        //    GameObject.Find("Player").transform.position = new Vector3(10.6f, 28, 0);
        //}

        //if (scene.name == "Nighttime" && firstTimeNightTime)
        //{
        //    firstTimeNightTime = false;
        //}

        //if (scene.name == "Yard")
        //{
        //    GameObject.Find("Player").transform.position = cellPos;
        //}

        //SceneManager.sceneLoaded -= ChangeSceneStartingPos;



    }
}
