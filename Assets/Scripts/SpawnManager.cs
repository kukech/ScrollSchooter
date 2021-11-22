using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject powerup;

    private float xSpawnArea = 15f;
    private const float zSpawnLine = 15f;
    private const float ySpawnPos = 3f;

    private float powerupSpawnTime = 10f;
    private float enemySpawnTime = 4f;
    private float startDelay = 1f;
    void Start()
    {
        InvokeRepeating("SpawnEnemy", startDelay, enemySpawnTime);
        InvokeRepeating("SpawnPowerup", startDelay, powerupSpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnEnemy()
    {
        float randomX = Random.Range(-xSpawnArea, xSpawnArea);
        int randomEnemy = Random.Range(0, enemies.Length);
        Vector3 spawnPos = new Vector3(randomX, ySpawnPos, zSpawnLine);
        Instantiate(enemies[randomEnemy], spawnPos, enemies[randomEnemy].transform.rotation);
    }
    void SpawnPowerup()
    {
        float randomX = Random.Range(-xSpawnArea, xSpawnArea);
        Vector3 spawnPos = new Vector3(randomX, ySpawnPos, zSpawnLine);
        Instantiate(powerup, spawnPos, powerup.transform.rotation);
    }
}
