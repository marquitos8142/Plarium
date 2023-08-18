using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir : MonoBehaviour
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
    [SerializeField] GameObject gameObjectToDeactivate13;
    [SerializeField] GameObject gameObjectToDeactivate14;
    [SerializeField] GameObject gameObjectToDeactivate15;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Destrucion")
        {
            gameObjectToDeactivate1.SetActive(false);
            gameObjectToDeactivate2.SetActive(false);
            gameObjectToDeactivate3.SetActive(false);
            gameObjectToDeactivate4.SetActive(false);
            gameObjectToDeactivate5.SetActive(false);
            gameObjectToDeactivate6.SetActive(false);
            gameObjectToDeactivate7.SetActive(false);
            gameObjectToDeactivate8.SetActive(false);
            gameObjectToDeactivate9.SetActive(false);
            gameObjectToDeactivate10.SetActive(false);
            gameObjectToDeactivate11.SetActive(false);
            gameObjectToDeactivate12.SetActive(false);
            gameObjectToDeactivate13.SetActive(false);
            gameObjectToDeactivate14.SetActive(false);
            gameObjectToDeactivate15.SetActive(false);

        }
    }

}
