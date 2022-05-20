using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> items;

    [SerializeField]
    private Transform itemSlotContainer;

    [SerializeField]
    private Transform itemSlotTemplate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RefreshUI()
    {
        int x = 0;
        int y = 0;

        float itemSlotCellSize = 30f;

        foreach (Item item in items)
        {

        }

    }
}
