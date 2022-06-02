using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SignalRecieveHandler : MonoBehaviour
{
    public void StartMugshot()
    {
        // actually the truck scnee
        SceneManager.LoadScene("TransitionYardToCell");

    }
}
