using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ShowHideCheckbox : MonoBehaviour
{
    public GameObject checkbox;

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Cell")
        {
            checkbox.SetActive(true);
        }

        if (SceneManager.GetActiveScene().name == "Nighttime" || SceneManager.GetActiveScene().name == "Fight Scene")
        {
            checkbox.SetActive(false);
        }
    }
}
