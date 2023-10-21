using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectBattery : MonoBehaviour
{
    public GameObject sbattery;
    public GameObject dbattery;
    public GameObject tbattery;
    public ScoreManager scoreManager;
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
        if (other.tag == "singleBat")
        {
            scoreManager.IncreaseSingleBat();
            Destroy(sbattery);
            Debug.Log(scoreManager.batteryCounter);
        }

        if (other.tag == "doubleBat") { 
        
            scoreManager.IncreaseDoubleBat();
       Destroy (dbattery);
        }

        if (other.tag == "tripleBat") { 
        
            scoreManager.IncreaseTripleBat();
            Destroy(tbattery);
        }
     }
}
