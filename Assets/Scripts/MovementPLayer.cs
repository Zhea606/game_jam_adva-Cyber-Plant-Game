using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPLayer : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    [SerializeField] private Vector2 direction;
    
    public bool isHittable = true;
    private Rigidbody2D rb2D;

    private float movimientoX;
    private float movimientoY;

    
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        movimientoX = Input.GetAxisRaw("Horizontal");
        movimientoY = Input.GetAxisRaw("Vertical");

        anim.SetFloat("MovementX", movimientoX);
        anim.SetFloat("MovementY", movimientoY);

        if(movimientoX !=0 || movimientoY !=0 )
        {
            anim.SetFloat("UltimoX",movimientoX);
            anim.SetFloat("UltimoY",movimientoY);
        }
        direction = new Vector2(movimientoX, movimientoY).normalized;

        
        
        
        //////
        // anim.SetBool("goUp", Input.GetButtonDown("Up"));
        // if(Input.GetButtonDown("Up"))
        // {
        //     anim.Play("player up");
        // }
        // anim.SetBool("goDown", Input.GetButtonDown("Down"));
        // anim.SetBool("goRight", Input.GetKey(KeyCode.D));
        // anim.SetBool("goLeft", Input.GetKey(KeyCode.A));

        // direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")).normalized;
    }

    private void FixedUpdate()
    {
        rb2D.MovePosition(rb2D.position + direction * movementSpeed * Time.fixedDeltaTime);
    }
    
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Box"))
        {
            isHittable = false;
        } 
    }
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Box"))
        {
            isHittable = true;
        } 
    }
    
    
}
