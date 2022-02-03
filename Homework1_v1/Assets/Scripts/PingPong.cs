using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPong : MonoBehaviour
{
    private Vector3 start, end, target;

    public float speed, radius;


    void Start()
    {
     
        start = transform.position;
        end = new Vector3(Random.Range(start.x - radius, start.x + radius), Random.Range(start.y - radius, start.y + radius), Random.Range(start.z - radius, start.z + radius));
        target = end;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed);
        if (transform.position == end) 
        {
            target = start;
        }
        if (transform.position == start)
        {
            target = end;
        }


    }
  
}
