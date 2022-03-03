using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField, Range(0,10)]
    float speed = 5.0f;
    [SerializeField]
    float rotationSpeed = 5.0f;



    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        Vector3 direction = new Vector3(horizontal,0,vertical);
        transform.Translate(direction*Time.deltaTime*speed);

        transform.Rotate(0, mouseX*Time.deltaTime*rotationSpeed, 0);

        Debug.Log(mouseX);
    }
}

