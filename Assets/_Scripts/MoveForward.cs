using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField, Tooltip("Object's speed (m/s)")]
    float speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, speed * Time.deltaTime,0f );
    }
}
