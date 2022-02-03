using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Spawner : MonoBehaviour
{
    public Text text;

    public Transform sp;
    private int number;
    public GameObject[] Prefabs;
    private GameObject Inst;
   
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(Inst != null)
            {
                Destroy(Inst);

            }
 
            number = Random.Range(0, Prefabs.Length);
            Inst = Instantiate(Prefabs[number], sp.position, Quaternion.identity);
           
            text.text = Prefabs[number].name;
        }
    }
}
