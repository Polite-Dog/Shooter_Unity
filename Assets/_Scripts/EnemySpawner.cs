using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    float startTime, endTime, spawnRate;

    [SerializeField, Tooltip("Prefab to be instantiated")]
    GameObject[] prefab;

    public string id;
    

    public List<Enemy> deathNotifications;

    Enemy enemy;

    public GameObject[] enemies;
    





    // Start is called before the first frame update
    void Start()
    {
        WaveManager.SharedInstance.waves.Add(this);
        
        Invoke("SpawnEnemy", startTime);
        //Invoke("CancelInvoke", endTime);

        gameObject.tag = id;

        deathNotifications = new List<Enemy>();
        
    }

    void SpawnEnemy()
    {
       for(int i = 0;i<prefab.Length; i++) 
        {
            
            Instantiate(prefab[i], transform.position, transform.rotation);
            
        }

        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        for (int i = 0; i < enemies.Length; i++)
        {
          
            enemy = enemies[i].GetComponent<Enemy>();
            if (enemy.id == id)
            {
                enemy.enemySpawner = this;
            }
        }
    }

    private void Update()
    {
        if(deathNotifications.Count == prefab.Length)
        {
            Debug.Log("Todos los enemigos de " + id + " han muerto");
            deathNotifications.Clear();
            SpawnEnemy();
        }
    }
}
