using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Muerte : MonoBehaviour
{
    public int Nivel = 1;
    public int Nivelanterior = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
                Character cplayer = collision.gameObject.GetComponent<Character>();
            if (cplayer.Leerdata.Vive())
            {
                cplayer.Leerdata.Restarvidas();
                cplayer.Leerdata.Murioplayer();
                SceneManager.LoadScene(Nivel);
            }
            if (cplayer.Leerdata.Leervidas() == 0)
            {
                SceneManager.LoadScene(Nivelanterior);
                cplayer.Leerdata.Murioplayer();
                cplayer.Leerdata.Resetvidas();
            }


        }
    }
}
