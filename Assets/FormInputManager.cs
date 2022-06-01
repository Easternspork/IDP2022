using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;

public class FormInputManager : MonoBehaviour
{
    public bool wouldYouBuy = false;
    public double sliderValue = 0f;
    public List<string> mostImprove;

    [SerializeField]
    public Slider slider;
    [SerializeField]
    public TMP_Dropdown dropdown;

    static FormInputManager instance; 

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    public static FormInputManager GetInstance()
    {
        return instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WouldYouBuy()
    {
        wouldYouBuy = !wouldYouBuy;
    }
    public void Enjoyment()
    {
        sliderValue = Math.Round(slider.value);
    }

    public void DropDown()
    {
        Debug.Log(i);
    }
}
