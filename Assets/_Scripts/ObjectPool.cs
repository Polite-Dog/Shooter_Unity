using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool SharedInstance;
    
    
    [SerializeField, Tooltip("Prefab to be shot")]
    GameObject prefab;

    [SerializeField]
    List<GameObject> pooledObjects;

    [SerializeField]
    int amountToPool;


    private void Awake()
    {
        if(SharedInstance == null)
        {
            SharedInstance = this;
        }
        else 
        {
            Debug.LogError("There is already another pool on the scene");
            Destroy(gameObject);
        }
    }


    private void Start()
    {
        pooledObjects = new List<GameObject>();
        GameObject tmp;
        for (int i = 0; i < amountToPool; i++)
        {
            tmp = Instantiate(prefab);
            tmp.SetActive(false);
            pooledObjects.Add(tmp);
        }
    }


    public GameObject GetFirstPooledObject()
    {
        for (int i = 0; i < amountToPool; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }


        return null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
