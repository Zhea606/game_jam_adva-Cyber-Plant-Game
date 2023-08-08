
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrullaje : MonoBehaviour
{
    [SerializeField] private float velocidadMovimiento;
    [SerializeField] private Transform[] puntosMovimientos;
    [SerializeField] private float distanciaMinima;

    private int siguientePunto = 0;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        //siguientePunto = Random.Range(0, puntosMovimientos.Length);
        spriteRenderer = GetComponent<SpriteRenderer>();
        Girar();
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, puntosMovimientos[siguientePunto].position, velocidadMovimiento * Time.deltaTime);

        if(Vector2.Distance(transform.position, puntosMovimientos[siguientePunto].position) < distanciaMinima)
        {
            //siguientePunto = Random.Range(0, puntosMovimientos.Length);
            //Girar();
            siguientePunto += 1;
            if(siguientePunto >= puntosMovimientos.Length)
            {
                siguientePunto = 0;
            }
            Girar();
        }
    }


    private void Girar()
    {
        if(transform.position.x < puntosMovimientos[siguientePunto].position.x)
        {
            spriteRenderer.flipX = true;
        } else
        {
            spriteRenderer.flipX = false;
        }
    }
}
