using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{

    [SerializeField, Range(0, 500)] float speed = 5.0f;


    [SerializeField, Range(0, 10)] float rotationSpeed = 1.0f;


    [SerializeField] float jumpForce = 3.0f;

    Rigidbody _rigidbody;

    





    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        
    }

    private void FixedUpdate()
    {
        

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, 0, vertical);
        

        _rigidbody.AddRelativeForce(direction.normalized * speed, ForceMode.Force);


        
        float mouseX = Input.GetAxis("Mouse X");

        _rigidbody.AddRelativeTorque(0,rotationSpeed*mouseX,0);
        
        if (Input.GetButtonDown("Jump"))
        {
            _rigidbody.AddRelativeForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        
    }

    
    
}

