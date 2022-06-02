using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetainNightTimePos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (!GameManager.GetInstance().firstTimeNightTime)
        {
            Debug.Log("scene pos changed");
            GameObject.Find("Player").transform.position = new Vector3(10.6f, 28, 0);
        }

        if (GameManager.GetInstance().firstTimeNightTime)
        {
            GameManager.GetInstance().firstTimeNightTime = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
