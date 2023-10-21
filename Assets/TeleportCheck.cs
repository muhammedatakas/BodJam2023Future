using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TeleportCheck : MonoBehaviour
{
    public bool b;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "teleport")
        {
            b = false;
        }
    else
        {
            b = true;
        }
    }


}
