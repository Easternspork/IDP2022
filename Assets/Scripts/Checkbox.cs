using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Checkbox : MonoBehaviour
{
    [SerializeField]
    private Sprite ticked;
    private Sprite unticked;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        if (gameObject.GetComponent<Image>().sprite == ticked)
        {
            gameObject.GetComponent<Image>().overrideSprite = unticked;

        } else
        {
            gameObject.GetComponent<Image>().overrideSprite = ticked;
        }
    }
}
