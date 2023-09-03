using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
        private Animator anim;

        void Start()
        {
            anim = GetComponent<Animator>();
        }

        void Update()
        {
            // Set the boolean parameter "IsWalking" to trigger the walk animation.
            // bool goUp = Input.GetKey(KeyCode.W); 
            // Replace with your condition.
            // anim.SetBool("goUp", goUp);
        }
    
}
