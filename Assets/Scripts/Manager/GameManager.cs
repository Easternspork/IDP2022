using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    private void Start()
    {
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Cell");
    }
}
