using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxs : MonoBehaviour
{
    [SerializeField] private GameObject newBox;
    [SerializeField] private GameObject oldBox;
    
   
   

    // Start is called before the first frame update
    void Start()
    {
        // Initialize firstPos and lastPos to the initial positions of the boxes.
        

    }
    private void Update()
    {
        if (Transfer.isAtAdult)
        {
            MoveBox();
        }
    }
    private void MoveBox()
    {
        oldBox.transform.position=new Vector3(newBox.transform.position.x,newBox.transform.position.y-50,oldBox.transform.position.z);

    }

    // Update is called once per frame




}
