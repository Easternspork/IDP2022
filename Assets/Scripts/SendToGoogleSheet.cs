using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SendToGoogleSheet : MonoBehaviour
{
    //STILL NEEDSTO BE SET SOMEHOW
    //MAYBE IN THE INTRO CUTSCENE OR END OF THE GAME
    public GameObject Username;
    public GameObject Time;
    public GameObject Score;

    private string a;
    private string b;
    private string c;

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
        Debug.Log(Username);
        Debug.Log(Time);
        Debug.Log(Score);
        Debug.Log(a);
        Debug.Log(b);
        Debug.Log(c);

        a = Username.GetComponent<InputField>().text;
        b = Time.GetComponent<InputField>().text;
        c = Score.GetComponent<InputField>().text;

        StartCoroutine(Post(a, b, c));
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