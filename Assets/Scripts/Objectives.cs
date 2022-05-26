using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Objectives : MonoBehaviour
{
    [SerializeField]
    private GameObject objectivesPanel;

    [SerializeField]
    private GameObject objectivePrefab;

    [SerializeField]
    private List<string[]> objectiveList;

    [SerializeField]
    private GameObject objectiveContainer;

    private int objectiveNumber;

    public static Objectives instance = null;

    // Start is called before the first frame update
    void Start()
    {
        objectiveList = new List<string[]>();

        // set objectiveList here >>
        // example for objective
        objectiveList.Add(new string[] { "objective 1", "objective 2" });
        objectiveList.Add(new string[] { "1objective 1", "objective 2" });
        objectiveList.Add(new string[] { "2objective 1", "objective 2" });

        if (instance != null)
        {
            Debug.LogError("two instances");
        }

        instance = this;

    }

    public static Objectives GetInstance()
    {
        return instance; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowObjectives()
    {
        objectivesPanel.SetActive(!objectivesPanel.activeSelf);
    }

    public void RenderObjectiveList()
    {
        int y = 0;
        foreach (string objective in objectiveList[objectiveNumber])
        {
            RectTransform objectiveRectTransform = Instantiate(objectivePrefab, objectiveContainer.transform.localPosition, objectiveContainer.transform.localRotation, objectiveContainer.transform).GetComponent<RectTransform>();
            objectiveRectTransform.gameObject.GetComponent<TextMeshProUGUI>().text = objective;
            objectiveRectTransform.gameObject.SetActive(true);
            objectiveRectTransform.localPosition = new Vector2(0, y * 50);
            y++;
        }

    }

    public void NextObjective()
    {
        objectiveNumber++;
        RenderObjectiveList();
    }



}
