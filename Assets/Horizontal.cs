using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horizontal : MonoBehaviour
{
    public float avance = 1;
    public float limD = 10;
    public float limI = 10;
    [SerializeField] GameObject gameObjectToDeactivate1;
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
            gameObjectToDeactivate1.SetActive(true);
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
}
