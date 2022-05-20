using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    private List<string> items;

    private static Inventory instance;

    [SerializeField]
    private GameObject canvas;
    [SerializeField]
    private GameObject itemTemplate;

    private bool showingInventory = false;

    [SerializeField]
    private Sprite keySprite;

    private void Start()
    {

        if (instance != null)
        {
            Debug.LogWarning("Two instances of inventory");
        }

        instance = this;

        items = new List<string>();

        items.Add("Key");

        Debug.Log(items);
    }

    public static Inventory GetInstance()
    {
        // fix this cuz im not allowed to use new keyword here
        return instance;
    }

    public void AddItem(string item)
    {
        items.Add(item);
    }

    public void RemoveItem(string item)
    {
        items.Remove(item);
    }

    public List<string> GetItemList()
    {
        return items;
    }

    public void ShowInventory()
    {
        canvas.SetActive(true);
        showingInventory = true;
        GameManager.GetInstance().disableMovement = true;
        RefreshInventory();
    }

    public void HideInventory()
    {
        canvas.SetActive(false);
        showingInventory = false;
        GameManager.GetInstance().disableMovement = false;
    }

    public void RefreshInventory()
    {
        int x = 0;
        int y = 0;

        float itemSlotCellSize = 100f;

        // destroy prev items on screen

        for (int i = 1; i < canvas.transform.childCount; i++)
        {
            Destroy(canvas.transform.GetChild(i).gameObject);
        }

        // refresh here

        foreach (string item in items)
        {
            RectTransform itemSlotRectTransform = Instantiate(itemTemplate, canvas.transform).GetComponent<RectTransform>();
            itemSlotRectTransform.gameObject.SetActive(true);
            itemSlotRectTransform.anchoredPosition = new Vector2(x * itemSlotCellSize, y * itemSlotCellSize);
            x++;
            if (x > 5)
            {
                x = 0;
                y++;
            }

            switch (item)
            {
                case "Key":
                   itemSlotRectTransform.GetChild(1).GetComponent<Image>().overrideSprite = keySprite;
                    break;
                default:
                    Debug.Log("default");
                    break;
            }

        }
    }

    private void Update()
    {


        // toggling between states

        bool gotInputAlready = false;


        if (Input.GetKeyDown(KeyCode.I) && showingInventory)
        {

            HideInventory();

            gotInputAlready = true;
        }

        if (Input.GetKeyDown(KeyCode.I) && !gotInputAlready)
        {

            ShowInventory();
        }
    }
}
