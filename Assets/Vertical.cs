using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vertical : MonoBehaviour
{
    public float avance = 1;
    public float limA = 10;
    public float limB = 10;
    bool muevederecha = true;
    bool activo = false;

    public void Activar()
    {
        activo = true;
    }


    // Update is called once per frame
    void Update()
    {
        if (activo)
        {
            if (transform.position.y > limA)
            {
                muevederecha = false;
            }
            if (transform.position.y < limB)
            {
                muevederecha = true;
            }
            if (muevederecha == true)
            {
                transform.position = new Vector3(transform.position.x , transform.position.y + avance, transform.position.z);
            }
            if (muevederecha == false)
            {
                transform.position = new Vector3(transform.position.x , transform.position.y - avance, transform.position.z);
            }
        }

    }
}
