using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private float horizontal;
    private float speed = 5f;
    private float jumpingPower = 13f;
    private bool isFacingRight = true;
    public Animator animator;
    private bool canDoubleJump = true;
   




    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    void Start()
    {
        
    }
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        animator.SetFloat("Speed", Mathf.Abs(horizontal));

       

        if (IsGrounded())
        {
           
            canDoubleJump = true;
            if (Input.GetKeyDown(KeyCode.W))
            {
           
                rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
                
            }


        }
        else
        {
           
            if (Input.GetKeyDown(KeyCode.W) && canDoubleJump == true)
            {
           
                rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
                canDoubleJump = false;
                animator.SetBool("isJump", true);
            }

        }

        if (Input.GetKeyUp(KeyCode.W) && rb.velocity.y > 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
         
        }

        if (rb.velocity.y <= 0) { 


            animator.SetBool("isJump", false);

            }

    Flip();
        
    }

    private void FixedUpdate()
    {

        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);

    }

    private bool IsGrounded()
    {
     
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);

    }


    
private void Flip()
    {

        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {

            isFacingRight = !isFacingRight;

            /*
            Vector3 localScare = transform.localScale;
            localScare.x *= -1f;
            transform.localScale = localScare;
            */

            transform.Rotate(0f, 180f, 0f);
        }


    }
}
