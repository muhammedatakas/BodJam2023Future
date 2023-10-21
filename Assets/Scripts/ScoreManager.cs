using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public double score = 0;
    public int batteryCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void IncreaseScore()
    {
        score += 1;
        scoreText.text = ((int)score).ToString();
        
    }
   public void IncreaseSingleBat()
    {
        batteryCounter += 1;
    }
public void IncreaseDoubleBat() {
        batteryCounter += 2;
    }
    public void IncreaseTripleBat()
    {
        batteryCounter += 3;
    }
public void DecreaseBattery()
    {
       if(batteryCounter > 0) { batteryCounter -= 1; } 
       
    }
}

