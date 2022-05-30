using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fade : MonoBehaviour
{
    [SerializeField]
    private Image black;

    [SerializeField]
    private Animator anim;

    public void Start()
    {

    }

    public void FadeScene(string sceneName)
    {
        StartCoroutine(Fading(sceneName));
    }

    IEnumerator Fading(string scene)
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => black.color.a == 1);
        SceneManager.LoadScene(scene);
    }
}
