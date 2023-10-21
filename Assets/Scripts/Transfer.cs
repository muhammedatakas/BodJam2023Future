using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transfer : MonoBehaviour
{
    public static bool isAtAdult;
    float coolDown = 3f;
    float lastTimeTransfer;
    public GameObject[] Players;
    int playerno;
    public GameObject camera;
    public ScoreManager scoreManager;
    void Start()
    {
        lastTimeTransfer = Time.time;
        playerno = 0;
    }
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.E)  && Time.time - lastTimeTransfer > coolDown && playerno==0 && scoreManager.batteryCounter > 0)
        {isAtAdult = true;  
            Players[1].transform.position = new Vector2(Players[0].transform.position.x,Players[0].transform.position.y + 51.0f);
            camera.transform.position = new Vector3(9,Players[1].transform.position.y,-10);
            Players[playerno].SetActive(false);
            playerno++;
            Players[playerno].SetActive(true);
            scoreManager.DecreaseBattery();
        }
        else if (Input.GetKeyDown(KeyCode.E)  && Time.time - lastTimeTransfer > coolDown && playerno == 1 && scoreManager.batteryCounter > 0 )
        {
            isAtAdult = false;
            Players[0].transform.position = new Vector2(Players[1].transform.position.x,Players[1].transform.position.y - 50.0f);
            camera.transform.position = new Vector3(9,Players[0].transform.position.y,-10);
            Players[playerno].SetActive(false);
            playerno--;
            Players[playerno].SetActive(true);
            scoreManager.DecreaseBattery();
        }
    }
    

}
