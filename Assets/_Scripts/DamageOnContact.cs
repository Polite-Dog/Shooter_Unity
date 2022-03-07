using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnContact : MonoBehaviour
{
    [SerializeField]
    private float damage;

    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
        

        Life life = other.GetComponent<Life>();

        if (life != null)
        {
            life.Amount -= damage;

        }
        else
        {
            life = other.GetComponentInChildren<Life>();
            
        }
    }
}
