using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorManager : MonoBehaviour
{
    public static GeneratorManager SharedInstance;

    public List<Generator> generators;


    private void Awake()
    {
        if(SharedInstance == null)
        {
            SharedInstance = this;
            generators = new List<Generator>();
        }
        else
        {
            Destroy(gameObject);
            Debug.LogWarning("There is already another manager on the scene. " + gameObject + " Has been destroyed");
        } 

    }
}
