using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class piecesPickupables : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // if (other.gameObject.CompareTag("Player"))
        // {
        //     bool piezaRecuperada = GameManager.Instance.ObjectFind();
        //  
        //     if (piezaRecuperada)
        //     {
        //         Destroy(this.gameObject);
        //     }
        //     Debug.Log("Objeto encontrado!");
        // }   
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.ObjectFind();
            Destroy(this.gameObject);
        }
    }

}
