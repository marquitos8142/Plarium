using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vertical : MonoBehaviour
{
    public float avance = 1;
    public float limA = 10;
    public float limB = 10;
    bool muevearriba = true;
    bool activo = false;


    // Start is called before the first frame update
    public void Activar()
    {
        activo = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(activo)
        {
            if (transform.position.y > limA)
            {
                muevearriba = false;

            }
            if (transform.position.y < limB)
            {
                muevearriba = true;

            }
            if (muevearriba == true)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + avance, transform.position.z);
            }
            if (muevearriba == false)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - avance, transform.position.z);
            }
        }
        
        
    }
}
