using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWaveManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform spawnPoint;
    public float timeBetweenWaves = 5f;
    public int numberOfWaves = 3;
    public int enemiesPerWave = 5;

    private int currentWave = 0;
    private float timeUntilNextWave;

    void Start()
    {
        timeUntilNextWave = timeBetweenWaves;
    }

    void Update()
    {
        if (currentWave < numberOfWaves)
        {
            if (timeUntilNextWave <= 0f)
            {
                StartWave();
                timeUntilNextWave = timeBetweenWaves;
            }
            else
            {
                timeUntilNextWave -= Time.deltaTime;
            }
        }
    }

    void StartWave()
    {
        Debug.Log("Wave " + (currentWave + 1) + " Started!");

        for (int i = 0; i < enemiesPerWave; i++)
        {
            SpawnEnemy();
        }

        currentWave++;

        if (currentWave == numberOfWaves)
        {
            Debug.Log("All waves completed! You've Won!");
        }
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
