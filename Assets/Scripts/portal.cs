using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class portal : MonoBehaviour
{
    [SerializeField] Data data;
    public int Escena = 1 ;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            data.Resetvidas();
            var Nivel = Escena;
            SceneManager.LoadScene(Nivel);
        }
    }
}
