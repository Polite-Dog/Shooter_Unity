using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    [Header("Points Amount")]
    [Tooltip("Min amount of points obtained by destroying the generator")]
    [SerializeField] int min;

    [Tooltip("Max amount of points obtained by destroying the generator")]
    [SerializeField] int max;


    private void Start()
    {
        GeneratorManager.SharedInstance.generators.Add(this);
    }


    private void OnDisable()
    {
        
        ScoreManager.SharedInstance.Amount += Random.Range(min, max + 1);
        GeneratorManager.SharedInstance.generators.Remove(this);
    }


}
