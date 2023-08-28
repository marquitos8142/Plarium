using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ascensor : MonoBehaviour
{
    public float avance = 1;
    public float limA = 10;
    public float limB = 10;
    bool muevearriba = true;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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
