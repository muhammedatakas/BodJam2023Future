using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour
{
    public ScoreManager scoreManager;
    public GameObject door;
    public Sprite openedDoorSprite;
    public Sprite closedDoorSprite;
    
    private bool isDoorOpen = false;

    void Update()
    {
       /* if (isDoorOpen)
        {
           
            if (Input.GetKeyDown(KeyCode.R))
            {
                CloseDoor();
            }
        }
        else
        {
           
            if (Input.GetKeyDown(KeyCode.R) && scoreManager.score == 1)
            {
                OpenDoor();
            }
        }
    */
        }

    void OpenDoor()
    {
        door.GetComponent<SpriteRenderer>().sprite = openedDoorSprite;
        isDoorOpen = true;
        door.GetComponent<Rigidbody2D>().simulated = false;
    }

    void CloseDoor()
    {
        door.GetComponent<SpriteRenderer>().sprite = closedDoorSprite;
        isDoorOpen = false;
        door.GetComponent<Rigidbody2D>().simulated = true;
    }

   

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player") && Input.GetKeyDown(KeyCode.R))
        {
           
            if (isDoorOpen)
            {
                CloseDoor();
            }
           else if(!isDoorOpen) 
            {
                OpenDoor();
            }
        }
    }
}
