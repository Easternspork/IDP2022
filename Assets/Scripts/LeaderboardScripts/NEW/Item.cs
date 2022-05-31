using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public string timestamp;
    public string username;
    public string time;
    public string score;
    public string feedback;

    public Item(Item d)
    {
        timestamp = d.timestamp;
        username = d.username;
        time = d.time;
        score = d.score;
        feedback = d.feedback;


    }
}
