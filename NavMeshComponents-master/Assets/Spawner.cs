using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawnDelay = 3f;

    public GameObject spawnObj;

    public Transform[] spawnPoints;

    float nextTimeToSpawn = 0f;

    void Update()
    {
        if (nextTimeToSpawn <= Time.time)
        {
            SpawnPrize();
            nextTimeToSpawn = Time.time + spawnDelay;
        }
    }

    void SpawnPrize()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomIndex];
        Instantiate(spawnObj, spawnPoint.position, spawnPoint.rotation);
    }
}
