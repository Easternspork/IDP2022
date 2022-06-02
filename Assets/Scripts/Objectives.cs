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

    [SerializeField]
    private GameObject showObjectiveButton; 

    // Start is called before the first frame update
    void Start()
    {
        showObjectiveButton.SetActive(false);

        objectiveList = new List<string[]>();

        // set objectiveList here >>
        // example for objective
        objectiveList.Add(new string[] { "Find shrimp for Cassius", "Find out who's the shrimp hoarder", "Talk to other prisoners" });
        objectiveList.Add(new string[] { "Investigate who took the shrimp", "Look around for objects"});
        objectiveList.Add(new string[] { "Talk to cassius to hand the shrimp over."});
        objectiveList.Add(new string[] { "Break out of cell using hairpin", "Find the prison gate", "Decipher puzzles to get the prison gate passcode"});
        objectiveList.Add(new string[] { "Find your way out through the maze"});

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
            objectiveRectTransform.localPosition = new Vector2(0, y * -50);
            y++;
        }

    }

    public void SetObjective(int n)
    {
        objectiveNumber = n;
        RenderObjectiveList();
    }

    public void ShowButton()
    {
        showObjectiveButton.SetActive(true);
    }

    public void HideObjectivesButton()
    {
        showObjectiveButton.SetActive(false);

    }
}
