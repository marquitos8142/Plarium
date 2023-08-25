using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D[] hits = Physics2D.RaycastAll(
    // Update is called once per frame
    void Update()
    {
        RaycastHit2D [] hits = Physics2D.RaycastAll(Vector3.left, transform.position, 100);
        foreach(RaycastHit2D hit in hits )
        {
            if (hit.collider.transform.GetComponent<Character>())
            {
                transform.GetComponent<Rigidbody2D>().simulated = true;


            }
        }

            

        //Debug.DrawRay(transform.position, Vector3.down*100);
    }
}
