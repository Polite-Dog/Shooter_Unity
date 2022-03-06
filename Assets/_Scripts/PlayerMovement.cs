using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    /*[SerializeField, Range(0,10)]
    float speed = 5.0f;
    [SerializeField]
    float gravity = -9.81f;
    [SerializeField]
    float jumpHeight = 2f;

    Vector3 velocity;

    [SerializeField]
    Transform groundCheck;
    [SerializeField]
    float groundDistance = 0.4f;
    [SerializeField]
    LayerMask groundMask;
    bool isGrounded;

    [SerializeField]
    CharacterController _characterController;*/


    private void Update()
    {
        /*isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        _characterController.Move(move*speed*Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        _characterController.Move(velocity * Time.deltaTime);


        if (Input.GetButtonDown("Jump"))
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }*/
        
    }
}

