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
    [SerializeField]
    private AudioClip doorOpenSound;

    protected override void OnInteract()
    {
        GameObject.Find("Sound").GetComponent<AudioSource>().PlayOneShot(doorOpenSound);

        SceneManager.LoadScene(changeScene);

    }


}
