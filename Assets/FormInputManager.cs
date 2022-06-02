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
    public GameObject sliderGameobject;
    [SerializeField]
    public GameObject dropdownGameobject;

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
        sliderValue = Math.Round(sliderGameobject.GetComponent<Slider>().value);
    }

    public void DropDown()
    {
        //Debug.Log(i);
        int bruh = dropdownGameobject.GetComponent<TMP_Dropdown>().value;
    }
}
