using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadExcel : MonoBehaviour
{
    public Item blankItem;
    public List<Item> itemDatabase = new List<Item>();

    public void LoadItemData()
    {
        itemDatabase.Clear();

        List<Dictionary<string, object>> data = CSVReader.Read("LeaderboardDatabase");
        for(var i = 0; i < data.Count; i++)
        {
            string timestamp = data[i]["NTimestamp"].ToString();
            string username = data[i]["NUsername"].ToString();
            string time = data[i]["NTime"].ToString();
            string score = data[i]["NScore"].ToString();
            string feedback = data[i]["NFeedback"].ToString();

            AddItem(timestamp, username, time, score, feedback);
        }
    }

    void AddItem(string timestamp, string username, string time, string score, string feedback)
    {
        Item tempItem = new Item(blankItem);

        tempItem.timestamp = timestamp;
        tempItem.username = username;
        tempItem.time = time;
        tempItem.score = score;
        tempItem.feedback = feedback;

        itemDatabase.Add(tempItem);
    }
}
