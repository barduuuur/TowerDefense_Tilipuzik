using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpavnEnemy : MonoBehaviour
{
    [SerializeField]public GameObject[] enemy; 
    [SerializeField]public Transform spawn;
    [SerializeField] private GameObject WinPanel;
    public float spawnRate = 2f; 
    private float nextSpawnTime = 0f;
    public int MobsToSpawn = 10;
    private int mobsSpawned = 0;

    public int EnemyDie = 0;

    void Update()
    {
        if (mobsSpawned < MobsToSpawn && Time.time >= nextSpawnTime)
        {
            SpawnRandomPrefab(); 
            nextSpawnTime = Time.time + spawnRate; 
        }
        if(EnemyDie == MobsToSpawn)
        {
            Win();
            Time.timeScale = 0f;
        }
    }

    void SpawnRandomPrefab()
    {
        if (enemy.Length == 0) return; 

        int randomIndex = Random.Range(0, enemy.Length); 
        GameObject prefabToSpawn = enemy[randomIndex]; 

        Instantiate(prefabToSpawn, spawn.position, spawn.rotation);
        mobsSpawned++;
    }

    public void Win()
    {
        WinPanel.SetActive(true);
    }
}
