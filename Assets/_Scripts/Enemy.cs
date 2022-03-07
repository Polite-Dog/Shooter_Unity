using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [Header("Points Amount")]
    [Tooltip("Min amount of points obtained by defeating the enemy")]
    [SerializeField] int min;

    [Tooltip("Max amount of points obtained by defeating the enemy")]
    [SerializeField]int max;




    private void OnDestroy()
    {
        ScoreManager.SharedInstance.Amount += Random.Range(min, max+1);
    }
}
