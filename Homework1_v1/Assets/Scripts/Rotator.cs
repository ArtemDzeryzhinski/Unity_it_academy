using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed;
    private Vector3 direction;

    void Start()
    {
        direction = new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), Random.Range(-5, 5));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(direction * speed * Time.deltaTime);
    }
}
