using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogTimeStampMaze : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TimeManager.GetInstance().puzzle3Time = TimeManager.GetInstance().timer;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
