using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    private static TimeManager instance = null;

    // Start is called before the first frame update
    [SerializeField]
    private GameObject timerGO;

    private TextMeshProUGUI timerText;

    public float timer = 1800.0f;
    private bool isTimer = false;

    public float puzzle1Time;
    public float puzzle2Time;
    public float puzzle3Time;
    public float puzzle4Time;

    // Start is called before the first frame update
    void Start()
    {
        if (instance != null)
        {
            Debug.LogWarning("Two instances of TimeManager");
        }
        instance = this;

        timerText = timerGO.transform.GetChild(0).GetComponent<TextMeshProUGUI>();

        timerGO.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isTimer)
        {
            timer -= Time.deltaTime;
            DisplayTime();
        }

        if (timer < 0)
        {
            SceneManager.LoadScene("Lose Scene");
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
        timerGO.SetActive(true);

    }

    public void StopTimer()
    {
        isTimer = false;
        timerGO.SetActive(false);
    }

    ///<param name = "penaltyTime" > Penalty time in seconds. </param>
    public void AddPenalty(int penaltyTime)
    {
        // TODO: add noise and visual cue (?)
        timer -= penaltyTime;
    }
}
