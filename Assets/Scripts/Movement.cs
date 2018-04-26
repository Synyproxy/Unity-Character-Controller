using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(CapsuleCollider))]
public class Movement : MonoBehaviour
{
    private Animator anim;
    private bool isWalking = false;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        //Turning
        Turn();
        //Jumping
        //Move
        Walk();
        Move();
    }

    void Walk()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            isWalking = !isWalking;
            anim.SetBool("Walk", isWalking);
        }
    }

    void Move()
    {
        anim.SetFloat("Forward", Input.GetAxis("Vertical"));
    }

    void Turn()
    {
        anim.SetFloat("Turn", Input.GetAxis("Horizontal"));
    }

}
