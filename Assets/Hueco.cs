using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hueco : MonoBehaviour
{
    [SerializeField] GameObject gameObjectToDeactivate1;
    [SerializeField] GameObject gameObjectToDeactivate2;
    [SerializeField] GameObject gameObjectToDeactivate3;
    [SerializeField] GameObject gameObjectToDeactivate4;
    [SerializeField] GameObject gameObjectToDeactivate5;
    [SerializeField] GameObject gameObjectToDeactivate6;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameObjectToDeactivate1.SetActive(false);
            gameObjectToDeactivate2.SetActive(false);
            gameObjectToDeactivate3.SetActive(false);
            gameObjectToDeactivate4.SetActive(false);
            gameObjectToDeactivate5.SetActive(false);
            gameObjectToDeactivate6.SetActive(false);

        }
    }


}
