﻿using UnityEngine;
using System.Collections;

public class Player2 : MonoBehaviour
{

    public float m_JumpSpeed = 400f;
    private bool m_jumping = false;
    private Rigidbody m_Rigidbody;
    private Animator m_Anim;
    private bool grounded = true;


    private void Awake()
    {
        m_Anim = GetComponent<Animator>();
        m_Rigidbody = GetComponent<Rigidbody>();
    }


    void Start()
    {

    }

 
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    private void Jump()
    {
        if (this.grounded)
        {
            m_Rigidbody.AddForce(new Vector2(0f, m_JumpSpeed));
            grounded = false;
          
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        grounded = true;
    }
}
