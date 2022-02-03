using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPong : MonoBehaviour
{
    private Vector3 start;
    public Vector3 direction;
    public float speed, distance; 


    void Start()
    {
        
        start = transform.position;
        direction = new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), Random.Range(-5, 5));
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, start) >= distance)
        {
            speed *= -1;
        }
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
