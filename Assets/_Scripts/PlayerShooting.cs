using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    
    
    [SerializeField, Tooltip("Place where the prefab will be installed")]
    Transform instatiationPoint;

    
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject bullet = ObjectPool.SharedInstance.GetFirstPooledObject();
            bullet.layer = LayerMask.NameToLayer("Player Bullet");
            bullet.transform.position = instatiationPoint.transform.position;
            bullet.transform.rotation = instatiationPoint.transform.rotation * Quaternion.Euler(90,0,0);
            bullet.SetActive(true);
        }




    }
}
