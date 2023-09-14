using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trampa : MonoBehaviour
{
    [SerializeField] GameObject gameObjectToDeactivate;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameObjectToDeactivate.SetActive(true);
    
        }
    }

 
}
