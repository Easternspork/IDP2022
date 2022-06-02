using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip cafeteria;

    public AudioClip gotocell;

    static SoundManager instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static SoundManager GetInstance()
    {
        return instance;
    }

    public void PlayCafeteria()
    {
        GameObject.Find("Sound").GetComponent<AudioSource>().PlayOneShot(cafeteria);

    }

    public void PlayGotoCell()
    {
        GameObject.Find("Sound").GetComponent<AudioSource>().PlayOneShot(gotocell);

    }
}
