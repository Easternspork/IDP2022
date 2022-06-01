using SimpleJSON;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Networking;
using System;

public class Read_Google_Sheet : MonoBehaviour
{
    public TextMeshProUGUI outputArea;

    //Start is called before the first frame update
    void Start()
    {
        RefreshLeaderboardData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RefreshLeaderboardData()
    {
        StartCoroutine(ObtainSheetData());
    }

    IEnumerator ObtainSheetData()
    {
        UnityWebRequest www = UnityWebRequest.Get("https://sheets.googleapis.com/v4/spreadsheets/1ndSvOuTRSFzks_BAKlrjI6L5mwNpQzoSc-n7iB5u3zo/values/Form%20Responses%201?alt=json&key=AIzaSyDB19bT0P-l1JcdMUHxs4wDEJ7-8DMuHpc");
        yield return www.SendWebRequest();
        if(www.isNetworkError || www.isHttpError)
        {
            Debug.Log("ERROR: " + www.error);
        }
        else
        {
            string updateText = "";
            string json = www.downloadHandler.text;
            var o = JSON.Parse(json);



            var comparer = Comparer<int>.Create((x, y) => y.CompareTo(x));
            SortedList<int, string[]> openWith = new SortedList<int, string[]>(comparer);

            foreach (var item in o["values"])
            {

                var itemo = JSON.Parse(item.ToString());

                try
                {

                    openWith.Add(int.Parse(itemo[0][3]), itemo[0]);
                }
                catch(Exception ex)
                {
                    updateText += itemo[0][0] + " | " + itemo[0][2];
                }

                //updateText += itemo[0]["gsx$ntimestamp"]["$t"] + ": " + itemo[0]["gsx$nusername"]["$t"] + ": " + itemo[0]["gsx$ntime"]["$t"] + "left | " + itemo[0]["gsx$nscore"]["$t"] + " (" + itemo[0]["gsx$nfeedback"]["$t"] + ")\n";
                //
            }

            //string[] header = openWith["Score"];
            //updateText += header[0] + " | " + header[1] + " | " + header[2] + " | " + header[3] + " | " + header[4] + "\n";

            //openWith.Remove("Score");

            foreach (var item in openWith)
            {
                updateText += item.Value[0] + " | " + item.Value[2] + "\n";
            }
        
            outputArea.text = updateText;
        }
    }
}

