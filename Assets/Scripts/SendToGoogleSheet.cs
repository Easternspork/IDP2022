using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendToGoogleSheet : MonoBehaviour
{
    //STILL NEED TO BE SET SOMEHOW
    //MAYBE IN THE INTRO CUTSCENE OR END OF THE GAME
    public GameObject username;
    public GameObject time;
    public GameObject score;

    private string Username;
    private string Time;
    private string Score;

    [SerializeField]
    private string BASE_URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSeol-4SlnZACGtPetc_LBuxyoql8hzfCg0sIjco69URB-dRvw/formResponse";

    IEnumerator Post(string username, string time, string score)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.50546822", username);
        form.AddField("entry.2039556782", time);
        form.AddField("entry.1459984345", score);
        byte[] rawData = form.data;
        WWW www = new WWW(BASE_URL, rawData);
        yield return www;
    }

    public void Send()
    {
        Username = username.GetComponent<UnityEngine.UI.InputField>().text;
        Time = time.GetComponent<UnityEngine.UI.InputField>().text;
        Score = score.GetComponent<UnityEngine.UI.InputField>().text;

        StartCoroutine(Post(Username, Time, Score));
    }


    /*   UNUSED FOR NOW
       // Start is called before the first frame update
       void Start()
       {

       }

       // Update is called once per frame
       void Update()
       {

       }
   */
}