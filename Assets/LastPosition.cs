using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastPosition : MonoBehaviour
{
    private void Start()
    {
        if (GameManager.GetInstance().yardPos != null)
        GameObject.Find("Player").transform.position = GameManager.GetInstance().yardPos;    
    }
}
