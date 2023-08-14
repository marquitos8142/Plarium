using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horizontal : MonoBehaviour
{
    public float avance = 1;
    public float limD = 10;
    public float limI = 10;
    bool muevederecha = true;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > limD)
        {
            muevederecha = false;
        }
        if (transform.position.x < limI)
        {
            muevederecha = true;
        }
        if(muevederecha == true)
        {
            transform.position = new Vector3(transform.position.x + avance, transform.position.y, transform.position.z);
        }
        if (muevederecha == false)
        {
            transform.position = new Vector3(transform.position.x - avance, transform.position.y, transform.position.z);
        }
    }
}
