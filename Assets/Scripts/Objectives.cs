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
        objectiveList.Add(new string[] { "Objective: Find shrimp for Cassius", "Objective: Find out who’s the shrimp hoarder", "Objective: Talk to other prisoners."});
        objectiveList.Add(new string[] { "Objective: Get the shrimp from Freg"});
        objectiveList.Add(new string[] { "Objective: Talk to Peter"});
        objectiveList.Add(new string[] { "Objective: Talk to Cassius"});
        objectiveList.Add(new string[] { "Objective: Talk to Joe"});
        objectiveList.Add(new string[] { "Objective: Break out of your cell and into the office"});
        objectiveList.Add(new string[] { "Objective: Decipher picture puzzle in order to get prison gate passcode"});
        objectiveList.Add(new string[] { "Objective: Get back to your cell incognito." });
        objectiveList.Add(new string[] { "Objective: Inform Cassius" });
        objectiveList.Add(new string[] { "Objective: Look for anything suspicious" });
        objectiveList.Add(new string[] { "Objective: Enter the Hole" });
        objectiveList.Add(new string[] { "Objective: Use letter to figure out the machine’s password" });
        objectiveList.Add(new string[] { "Objective: Enter the Maze" });
        objectiveList.Add(new string[] { "Objective: Make your way through the labyrinths." });
        objectiveList.Add(new string[] { "Objective: Input password into methane machine." });
        objectiveList.Add(new string[] { "Last Objective: Go Home" });

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

    public void setObjective(int n)
    {
        objectiveNumbe = n;
        RenderObjectiveList();
    }

}
