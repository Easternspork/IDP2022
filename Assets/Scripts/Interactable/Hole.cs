using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Hole : Interactable
{
    [SerializeField]
    private string sceneToLoad;

    [SerializeField]
    private AudioClip doorPickSound;

    public override void OnDialogueEnd()
    {
        SceneManager.LoadScene(sceneToLoad);
        GameObject.Find("Sound").GetComponent<AudioSource>().PlayOneShot(doorPickSound);

    }
}
