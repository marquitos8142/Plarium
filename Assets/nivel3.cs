using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nivel3: MonoBehaviour

{
    [SerializeField] GameObject gameObjectToDeactivate1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //SceneManager.LoadScene(0);
            gameObjectToDeactivate1.SetActive(true);
        }
    }
}
