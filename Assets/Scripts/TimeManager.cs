using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeManager : MonoBehaviour
{
    private static TimeManager instance = null;

    // Start is called before the first frame update
    [SerializeField]
    private TextMeshProUGUI timerText;

    private float timer = 1800.0f;
    private bool isTimer = false;

    // Start is called before the first frame update
    void Start()
    {
        if (instance != null)
        {
            Debug.Log("Two instances of dialogueManger");
        }
        instance = this;

    }

    // Update is called once per frame
    void Update()
    {
        if (isTimer)
        {
            timer -= Time.deltaTime;
            DisplayTime();
        }
    }

    private void DisplayTime()
    {
        int minutes = Mathf.FloorToInt(timer / 60.0f);
        int seconds = Mathf.FloorToInt(timer - minutes * 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }

    public static TimeManager GetInstance()
    {
        // fix this cuz im not allowed to use new keyword here
        return instance;
    }

    public void StartTimer()
    {
        isTimer = true;
    }

    public void StopTimer()
    {
        isTimer = false;
    }
}
