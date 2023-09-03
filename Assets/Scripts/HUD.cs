using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class HUD : MonoBehaviour
{
    public GameObject[] pieces;
    public GameObject winUI;
public AudioSource bkSound;
    
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
        if (pieces.Length == index + 1)
        {
            GameObject enemy = GameObject.FindWithTag("Enemy");
            Destroy(enemy);

            winUI.SetActive(true);
            bkSound.Stop();
        }
        
    }
}
