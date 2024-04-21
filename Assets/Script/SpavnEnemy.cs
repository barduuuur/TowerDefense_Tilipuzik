using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpavnEnemy : MonoBehaviour
{
    [SerializeField]public GameObject[] enemy; 
    [SerializeField]public Transform spawn; 
    public float spawnRate = 2f; 
    private float nextSpawnTime = 0f;

    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnRandomPrefab(); 
            nextSpawnTime = Time.time + spawnRate; 
        }
    }

    void SpawnRandomPrefab()
    {
        if (enemy.Length == 0) return; 

        int randomIndex = Random.Range(0, enemy.Length); 
        GameObject prefabToSpawn = enemy[randomIndex]; 

        Instantiate(prefabToSpawn, spawn.position, spawn.rotation); 
    }
}
