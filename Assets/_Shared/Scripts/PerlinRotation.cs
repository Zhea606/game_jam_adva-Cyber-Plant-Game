using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PerlinRotation : MonoBehaviour {
  [Header("Configuration")]
  public float scale = 20;
  public float speed = 1;

  [Header("Information")]
  public float x;
  public float y;
  public float z;

  [Header("Initialization")]
  public Rigidbody body;

  void Reset () {
    body = GetComponent<Rigidbody>();
  }

  void OnEnable () {
    x = Random.Range(0,10f); y = Random.Range(0,10f); z = Random.Range(0,10f);
  }

  void Update () {
    body.MoveRotation(Quaternion.Euler(GetThePerlin(x), GetThePerlin(y), GetThePerlin(z)));
  }

  float GetThePerlin (float component) {
    return Mathf.Lerp(-scale, scale, Mathf.PerlinNoise(component, Time.time * speed));
  }
}
