using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Checkbox : MonoBehaviour
{
    public GameObject checkboxCanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void XButton()
    {
        checkboxCanvas.SetActive(!checkboxCanvas.activeSelf);
    }

    public void ToggleView()
    {
        checkboxCanvas.SetActive(true);
    }
}
