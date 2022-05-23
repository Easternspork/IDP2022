using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SimpleDoor : Interactable
{
    [SerializeField]
    private string changeScene = "Cell";
    private float coordinateX = 10.6f;
    private float coordinateY = 28f;

    protected override void OnInteract()
    {
        GameManager.GetInstance().HandleSceneChange();
        SceneManager.LoadScene("Cell");
    }


}
