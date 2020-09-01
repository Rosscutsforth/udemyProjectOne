using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject[] hazards;

    private float spawnInterval;
    public float startSpawnInterval;

    public float minSpawnInterval;
    public float spawnDecrease;

    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            if (spawnInterval <= 0)
            {
                Transform randomSpawnPoint = spawnPoints[UnityEngine.Random.Range(0, spawnPoints.Length)];
                GameObject randomHazard = hazards[UnityEngine.Random.Range(0, hazards.Length)];

                Instantiate(randomHazard, randomSpawnPoint.position, Quaternion.identity);

                if (startSpawnInterval > minSpawnInterval)
                {
                    startSpawnInterval -= spawnDecrease;
                }

                spawnInterval = startSpawnInterval;
            }
            else
            {
                spawnInterval -= Time.deltaTime;
            }
        }
    }
}
