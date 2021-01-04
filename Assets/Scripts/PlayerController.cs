using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour

{
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    public float moveSpeed = 2.0f;
    public float jumpForce = 1.0f;
    public float gravityValue = -9.81f;

    private void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
    }

    void Update()
     {
       
     //   groundedPlayer = Physics.CheckSphere(new Vector3(transform.position.x, transform.position.y - 1, transform.position.z), 0.4f, groundedPlayer);

        //moving
        float x = Input.GetAxisRaw("Horizontal") * moveSpeed;
        float y = Input.GetAxisRaw("Vertical") * moveSpeed;

        //jumping
     //   if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
     //       rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);

      
     //   Vector3 move = transform.right * x + transform.forward * y;

     //   rb.velocity = new Vector3(move.x, rb.velocity.y,move.z);
    }
}