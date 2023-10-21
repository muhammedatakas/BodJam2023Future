using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showBattery : MonoBehaviour
{
    public ScoreManager scoreManager;
    public GameObject battery;
    public Sprite showemptyBattery;
    public Sprite showsBattery;
    public Sprite showdBattery;
    public Sprite showtBattery;
    public Sprite showfullBattery;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreManager.batteryCounter == 0) { battery.GetComponent<SpriteRenderer>().sprite = showemptyBattery; }
        if (scoreManager.batteryCounter == 1) { battery.GetComponent<SpriteRenderer>().sprite = showsBattery; }
        if (scoreManager.batteryCounter == 2) { battery.GetComponent<SpriteRenderer>().sprite = showdBattery; }
        if (scoreManager.batteryCounter == 3) { battery.GetComponent<SpriteRenderer>().sprite = showtBattery; }
        if (scoreManager.batteryCounter >= 4) { battery.GetComponent<SpriteRenderer>().sprite = showfullBattery; }
    }
}
