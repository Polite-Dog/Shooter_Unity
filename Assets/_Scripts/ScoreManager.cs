using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager SharedInstance;
    
    
    [Tooltip("Number of points in the current game")] 
    [SerializeField] int amount;

    public int Amount
    {
        get => amount;
        set => amount = value;
    }


    private void Awake()
    {
        if(SharedInstance == null)
        {
            SharedInstance = this;
        }
        else
        {
            Debug.LogWarning("Duplicated Score Manager; " + gameObject + " will be destroyed");
            Destroy(gameObject);
        }
    }




}
