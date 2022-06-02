using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCheckboxActive : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Checkbox").SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
