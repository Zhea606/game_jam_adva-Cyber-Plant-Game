using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TiraPelotas : MonoBehaviour {
  // el tiempo que debe pasar entre pelota y pelota generada
  [Header("Configuration")]
  public float tiempoParaGenerarPelota = 2;

  // el tiempo que ha pasado el script sin generar una pelota
  [Header("Information")]
  public float tiempoSinGenerarPelota = 0;

  // el prefab que va a instanciar
  [Header("Initialization")]
  public GameObject prefabPelota;

  void Update () {
    tiempoSinGenerarPelota += Time.deltaTime;
    if (tiempoSinGenerarPelota >= tiempoParaGenerarPelota) {
      tiempoSinGenerarPelota = 0;
      GameObject creada = Instantiate(prefabPelota);
      // pone la pelota creada en la posición del generador
      creada.transform.position = transform.position;
    }
  }
}
