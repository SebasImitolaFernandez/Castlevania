using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerMove : MonoBehaviour
{
    //Movimientos eje Horizontal
    public float runSpeed = 2;
    //Salto vertical
    public float jumpSpeed = 3;

    public int maxJumps = 2;


    Rigidbody2D rd2D;

    public bool betterJump=false;

    public float fallMultiplier=0.5f;

    public float lowJumpMultiplier=1f;
    Animator animator;

    int jumpsLeft;
    bool jumpPressed;
    SpriteRenderer sprite;



    void Start()
    {
        rd2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
            sprite = GetComponent<SpriteRenderer>();

        jumpsLeft = maxJumps;

    } 

    void Update()
    {
        // Guardamos la pulsación para usarla en FixedUpdate
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpPressed = true;
        }
    }

    // FixedUpdate se usa para físicas
    void FixedUpdate()
    {
        float moveInput = 0;

        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rd2D.linearVelocity = new Vector2(runSpeed, rd2D.linearVelocity.y);
            sprite.flipX = false;
        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rd2D.linearVelocity = new Vector2(-runSpeed, rd2D.linearVelocity.y);
            sprite.flipX = true;
        }   
        else
        {
            rd2D.linearVelocity = new Vector2(0, rd2D.linearVelocity.y);
        }


        // Al tocar el suelo (y no estar subiendo) recuperamos los saltos
        if (CheckGround.isGrounded && rd2D.linearVelocity.y <= 0.01f)
        {
            jumpsLeft = maxJumps;
        }

        // Salto y doble salto
        if (jumpPressed && jumpsLeft > 0)
        {
            rd2D.linearVelocity = new Vector2(rd2D.linearVelocity.x, jumpSpeed);
            jumpsLeft--;
        }
        jumpPressed = false;
        
        if (betterJump)
        {
            if (rd2D.linearVelocity.y<0)
            {
                rd2D.linearVelocity += Vector2.up*Physics2D.gravity.y*(fallMultiplier)*Time.deltaTime;
            }

            if (rd2D.linearVelocity.y>0 && !Input.GetKey("space"))
            {
                rd2D.linearVelocity += Vector2.up*Physics2D.gravity.y*(lowJumpMultiplier)*Time.deltaTime;

            }
        }
        // Enviamos el valor absoluto de la velocidad al Animator
        animator.SetFloat("Speed", Mathf.Abs(rd2D.linearVelocity.x));
    }
} 