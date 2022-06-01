using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastPosition : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("thing qed");
        Debug.Log(GameManager.GetInstance().yardPos);

        if (GameManager.GetInstance().yardPos != Vector3.zero)
        {
            Debug.Log("yard pos");

            GameObject.Find("Player").transform.position = GameManager.GetInstance().yardPos;
        }
        else
        {
            Debug.Log("cell pos");
            GameObject.Find("Player").transform.position = GameManager.GetInstance().cellPos;

        }
    }
}
