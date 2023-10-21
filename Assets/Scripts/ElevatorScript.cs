using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorScript : MonoBehaviour
{
    public Transform[] stops;
     int speed = 3;
    int start;
    void Start()
    {
        start = 0;
        transform.position = Vector3.MoveTowards(transform.position, stops[start].position, speed * Time.deltaTime);
    }
    void Update()
    {
        if (transform.position == stops[start].position)
        {
            start++;
        }
        if (start >= stops.Length)
        {
            start = 0;
        }
        transform.position = Vector3.MoveTowards(transform.position, stops[start].position, speed * Time.deltaTime);
    }
}
