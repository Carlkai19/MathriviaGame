using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    //SCRIPT FOR PLAYER MOVEMENT 
    //variables for movement 
    public float moveSpeed;
    public Rigidbody2D rb;
    //private Vector2 MoveDirection; RAWAXIS
    public InputAction PlayerControls;
  
    Vector2 moveDirection = Vector2.zero;

    public Animator animator;

    private void OnEnable()
    {
        PlayerControls.Enable();
    }

    private void OnDisable()
    {
        PlayerControls.Disable();    
    }

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
       // float moveX = Input.GetAxisRaw("Horizontal");
       // float moveY = Input.GetAxisRaw("Vertical");
       //MoveDirection = new Vector2(moveX, moveY); this should be on with the GetAxisRaw. 

        moveDirection = PlayerControls.ReadValue<Vector2>(); //NEW UNITY SYSTEM

        animator.SetFloat("Horizontal", moveDirection.x);
        animator.SetFloat("Vertical", moveDirection.y);
       animator.SetFloat("Speed", moveDirection.sqrMagnitude);
    }

   
   


    void Move()
    {
       // rb.MovePosition(rb.position + MoveDirection.normalized * moveSpeed * Time.fixedDeltaTime); Goes with the AxisRaw
       rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }
}
