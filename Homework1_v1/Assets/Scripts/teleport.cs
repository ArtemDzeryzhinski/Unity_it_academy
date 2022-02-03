using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    private Vector3 sp;
    public int Radius;
    private float TimeBtwTp;
    public float StartTimeBtwTp;

    void Awake()
    {
        sp = transform.position;
        TimeBtwTp = StartTimeBtwTp;
    }

    void Update()
    {
        if (TimeBtwTp <= 0)
        {
           
            Vector3 tp = new Vector3(Random.Range((sp.x - Radius), (sp.x + Radius)), Random.Range((sp.y - Radius), (sp.y + Radius)), Random.Range((sp.z - Radius), (sp.z + Radius)));
            transform.position = tp;
            TimeBtwTp = StartTimeBtwTp;
        }
        else TimeBtwTp -= Time.deltaTime;
    }
}
