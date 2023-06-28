using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinchos : MonoBehaviour
{
    [SerializeField] GameObject gameObjectToDeactivate1;
    [SerializeField] GameObject gameObjectToDeactivate2;
    [SerializeField] GameObject gameObjectToDeactivate3;
    [SerializeField] GameObject gameObjectToDeactivate4;
    [SerializeField] GameObject gameObjectToDeactivate5;
    [SerializeField] GameObject gameObjectToDeactivate6;
    [SerializeField] GameObject gameObjectToDeactivate7;
    [SerializeField] GameObject gameObjectToDeactivate8;
    [SerializeField] GameObject gameObjectToDeactivate9;
    [SerializeField] GameObject gameObjectToDeactivate10;
    [SerializeField] GameObject gameObjectToDeactivate11;
    [SerializeField] GameObject gameObjectToDeactivate12;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameObjectToDeactivate1.SetActive(true);
            gameObjectToDeactivate2.SetActive(true);
            gameObjectToDeactivate3.SetActive(true);
            gameObjectToDeactivate4.SetActive(true);
            gameObjectToDeactivate5.SetActive(true);
            gameObjectToDeactivate6.SetActive(true);
            gameObjectToDeactivate7.SetActive(true);
            gameObjectToDeactivate8.SetActive(true);
            gameObjectToDeactivate9.SetActive(true);
            gameObjectToDeactivate10.SetActive(true);
            gameObjectToDeactivate11.SetActive(true);
            gameObjectToDeactivate12.SetActive(true);

        }
    }


}
