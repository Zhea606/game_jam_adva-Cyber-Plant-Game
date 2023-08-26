using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : MonoBehaviour
{
    public GameObject[] pieces;

    void Start()
    {
        // Desactivar los objetos en el array al inicio del juego
        foreach (GameObject piece in pieces)
        {
            piece.SetActive(false);
        }
    }
    
    public void RecollectPiece(int index)
    {
        pieces[index].SetActive(true);
    }
}
