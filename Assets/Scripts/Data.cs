using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "data player", order = 1)]
public class Data : ScriptableObject
{
    [SerializeField] private int vidas = 3;
    [SerializeField] bool estaVivo = true;

    public bool Vive()
    {
        return estaVivo;
    }
    public void Murioplayer()
    {
        estaVivo = false;
    }
    public void Reviveplayer()
    {
        estaVivo = true;
    }
    public int Leervidas()
    {
        return vidas;

    }
    public void Restarvidas()
    {
        vidas -= 1;
    }
    public void Resetvidas()
    {
        vidas = 3;
    }

}