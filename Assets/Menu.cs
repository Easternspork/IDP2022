using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField]
    private GameObject leaderboard;

    [SerializeField]
    private GameObject keybinds;

    [SerializeField]
    private GameObject xButton;
    // Start is called before the first frame update
    void Start()
    {
        HideAnyOpenTabs();   
    }

    public void ShowLeaderboard()
    {
        leaderboard.SetActive(true);
        xButton.SetActive(true);

    }

    public void ShowCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void ShowKeybinds()
    {
        keybinds.SetActive(true);
        xButton.SetActive(true);

    }

    public void HideAnyOpenTabs()
    {
        leaderboard.SetActive(false);
        keybinds.SetActive(false);
        xButton.SetActive(false);
    }
}
