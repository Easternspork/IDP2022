using SimpleJSON;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Networking;

public class Read_Google_Sheet : MonoBehaviour
{
    public string outputArea;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ObtainSheetData());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ObtainSheetData()
    {
        UnityWebRequest www = UnityWebRequest.Get("https://spreadsheets.google.com/feeds/list/1ndSvOuTRSFzks_BAKlrjI6L5mwNpQzoSc-n7iB5u3zo/od6/public/values?alt=json");
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

            foreach (var item in o["feed"]["entry"])
            {
                var itemo = JSON.Parse(item.ToString());

                updateText += itemo[0]["gsx$username"]["$t"] + ": " + itemo[0]["gsx$time"]["$t"] + "left | " + item[0]["gsx$score"]["$t"] + " (" + itemo[0]["gsx$feedback"]["$t"] + ")";
            }
        
            outputArea.text = updateText;
        }
    }
}

