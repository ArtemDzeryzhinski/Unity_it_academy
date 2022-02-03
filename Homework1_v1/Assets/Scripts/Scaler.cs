using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    private Vector3 endSize;
    void Start()
    {
        endSize = new Vector3(Random.Range(1, 5), Random.Range(1, 5), Random.Range(1, 5));
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, endSize, Time.deltaTime);
    }
}
