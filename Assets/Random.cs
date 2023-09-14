using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class andom : MonoBehaviour
{
    float trampa = Random.Range(0, 2);
    Vertical vertical;
    Horizontal horizontal;
    void Start()
    {
        vertical = GetComponent<Vertical>();

    }
    // Update is called once per frame
    void Update()
    {
       if (trampa == 1)
        {
            
        }
    }
    
}
