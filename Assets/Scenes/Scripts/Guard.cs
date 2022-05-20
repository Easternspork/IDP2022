using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guard : MonoBehaviour
{
    public struct GuardTriggerOrientation
    {
        int offSetX;
        int offSetY;
        int sizeX;
        int sizeY;
    }

    [SerializeField]
    private BoxCollider2D guardPerspective;

    public GuardTriggerOrientation right;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        
    }
}
