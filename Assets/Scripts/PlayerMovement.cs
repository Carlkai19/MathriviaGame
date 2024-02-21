using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //SCRIPT FOR PLAYER MOVEMENT 
    //variables for movement 
    public float moveSpeed;
    public Rigidbody2D rb;
    private Vector2 MoveDirection;

    public Animator animator;

   

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
    }

    void FixedUpdate()
    {
        Move();
    }

     void ProcessInput()
    { //controls
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        MoveDirection = new Vector2(moveX, moveY);

        animator.SetFloat("Horizontal", moveX);
        animator.SetFloat("Vertical", moveY);
        animator.SetFloat("Speed", MoveDirection.sqrMagnitude);

    }

    void Move()
    {
        rb.MovePosition(rb.position + MoveDirection.normalized * moveSpeed * Time.fixedDeltaTime);

    }
}
