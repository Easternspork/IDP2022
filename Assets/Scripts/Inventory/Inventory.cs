using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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

    [SerializeField]
    private Sprite hairpinSprite;

    [SerializeField]
    private Sprite shrimpSprite;

    private void Start()
    {

        if (instance != null)
        {
            Debug.LogWarning("Two instances of inventory");
        }

        instance = this;

        items = new List<string>();


    }

    public static Inventory GetInstance()
    {
        // fix this cuz im not allowed to use new keyword here
        return instance;
    }

    public void AddItem(string item)
    {
        items.Add(item);
        RefreshInventory();
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
        if (!DialogueManager.GetInstance().inDialogue)
        {
            canvas.SetActive(true);
            showingInventory = true;
            GameManager.GetInstance().disableMovement = true;
            RefreshInventory();
        }
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

        int itemSlotCellSize = 150;

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
            itemSlotRectTransform.anchoredPosition = new Vector2(x * itemSlotCellSize, 0);
            x++;

            itemSlotRectTransform.SetSiblingIndex(items.Count - items.IndexOf(item));

            switch (item)
            {
                case "Key":
                    SetItem(itemSlotRectTransform, keySprite, "Key", "A key used to access a special room in the prison.");
                    break;
                case "Hairpin":
                    SetItem(itemSlotRectTransform, hairpinSprite, "Hairpin", "Looks old and dirty. Might be able to be used as a lock pick.");
                    break;
                case "Shrimp":
                    SetItem(itemSlotRectTransform, shrimpSprite, "Tasty shrimp", "A delicacy in the PRF. Cassius might be interested in it.");
                    break;
                default:
                    Debug.Log("default");
                    break;
            }

        }
    }

    private void SetItem(RectTransform rectTransform, Sprite itemSprite, string itemName, string itemDecription)
    {

        rectTransform.GetChild(0).GetComponent<Image>().overrideSprite = itemSprite;
        rectTransform.GetChild(1).GetChild(1).GetComponent<TextMeshProUGUI>().text = itemName;
        rectTransform.GetChild(1).GetChild(2).GetComponent<TextMeshProUGUI>().text = itemDecription;
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
