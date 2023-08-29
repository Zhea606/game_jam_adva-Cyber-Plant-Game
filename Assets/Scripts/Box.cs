using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class Box : MonoBehaviour
{
  

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Player"))
        {
           // Debug.Log("Jugador dentro");
            
    
            //Mensaje en canvas: "Encontraste una pieza del disco de Chayanne!"
        }   
    }


   
}

