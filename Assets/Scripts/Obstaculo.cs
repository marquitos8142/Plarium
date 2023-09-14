using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    [SerializeField] GameObject gameObjectToDeactivate1;

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D [] hits = Physics2D.RaycastAll(transform.position, Vector3.down, 100);
        foreach(RaycastHit2D hit in hits )
        {
            if (hit.collider.transform.GetComponent<Character>())
            {
                transform.GetComponent<Rigidbody2D>().simulated = true;

              
            }
        }

            

        Debug.DrawRay(transform.position, Vector3.down*100);
    }
}
