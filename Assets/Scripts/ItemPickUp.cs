using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemPickUp : MonoBehaviour
{
    [SerializeField]

    public string interactableName;

    private bool inRange;

    Collider2D keyco = null;


    // Start is called before the first frame update
    void Start()
    {
        keyco = GetComponent<Collider2D>();
        inRange = false;
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inRange)
        {
            PickedUp();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            inRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        inRange = false;
    }

    private void PickedUp()
    {
        keyco.gameObject.SetActive(false);
        //Add key to inventory
    }
}