using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class ItemDesc : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField]
    GameObject descriptionContainer;

    public string description;
    [SerializeField]
    private TextMeshProUGUI descriptionUI;
    
    public string itemName;
    [SerializeField]
    private TextMeshProUGUI nameUI;

    private bool mouseOver = false;

    private void Start()
    {
        descriptionContainer.SetActive(false);

    }

    private void Update()
    {
        descriptionContainer.SetActive(mouseOver);
        if (mouseOver)
        {
            Debug.Log("Mouse Over");
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        mouseOver = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        mouseOver = false;
    }
}
