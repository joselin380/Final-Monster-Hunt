using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemiesPrefab;
    private float spawnRangeX = 30;
    private float spawnRangeZ = 8;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        // Call method to randomly spawn enemies
        InvokeRepeating("SpawnRandomEnemies", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomEnemies()
    {
        int enemyIndex = Random.Range(0, enemiesPrefab.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, Random.Range(-spawnRangeZ, spawnRangeZ));
        Instantiate(enemiesPrefab[enemyIndex], spawnPos, enemiesPrefab[enemyIndex].transform.rotation);
    }
}
