using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectMechanic : MonoBehaviour
{
    
    public ScoreManager scoreManager;
    public GameObject anahtar;
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
        if (other.CompareTag("key"))
        {
            
            scoreManager.IncreaseScore();
            Destroy(anahtar);
            Debug.Log(scoreManager.score);
        }
    }
}
