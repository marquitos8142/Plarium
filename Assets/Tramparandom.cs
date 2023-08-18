using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tramparandom : MonoBehaviour
{
    int trampa  ;
    Vertical vertical;
    Horizontal horizontal;
    void Start()
    {
        vertical = GetComponent<Vertical>();
        horizontal = GetComponent<Horizontal>();
        trampa = Random.Range(0, 2);

    }
    // Update is called once per frame
    void Update()
    {
       if (trampa == 1)
        {
            vertical.Activar();

        }else
        {
            horizontal.Activar();
        }
    }
    
}
