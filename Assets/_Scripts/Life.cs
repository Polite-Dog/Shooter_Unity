using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    [SerializeField] public float amount;


    [Tooltip("Texture that the generator will have when it is burned (This field is only used by generators)")] 
    [SerializeField]Material burnedGeneratorMaterial;

    [SerializeField]
    private int numberOfDeathAnims = 2;
    public float Amount 
    { get => amount; 
        set
        {
            amount = value;
            
            if(amount <= 0 && !CompareTag("Generator"))
            {
                //Destroy(gameObject);
                ParticleSystem explosion = GetComponentInChildren<ParticleSystem>();
                explosion.Play();

                Animator animator = GetComponent<Animator>();
                animator.SetFloat("DeathAnim", Random.Range(0,numberOfDeathAnims));
                animator.SetTrigger("Killed");

                Destroy(gameObject, 5);
            }
            else if (amount <= 0 && CompareTag("Generator"))
            {
                MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
                meshRenderer.material = burnedGeneratorMaterial;
                GameObject burningDetector = gameObject.transform.GetChild(0).gameObject;
                burningDetector.SetActive(false);
            }
            

            
        } 
    }
}
