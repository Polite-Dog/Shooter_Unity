using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    [SerializeField]
    float destructionDelay;
    
    // Start is called before the first frame update
    void OnEnable()
    {
        Invoke("HideObject", destructionDelay);
    }

    void HideObject()
    {
        gameObject.SetActive(false);
    }
}
