using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedlingSpawner : MonoBehaviour
{

    public GameObject[] seedlings;
    public GameObject player;

    //timing variables
    public float initialSpawnCountdown = 20;
    public float spawnInterval;
    public float spawnIntervalRandomizer;

    //audio variables


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SpawnSeedling();
    }

    public void SpawnSeedling()
    {
        if(player != null)
        {
            if(initialSpawnCountdown > 0)
            {
                initialSpawnCountdown -= Time.deltaTime;
            }

            GameObject randomSeedling = seedlings[UnityEngine.Random.Range(0, seedlings.Length)];

            if(initialSpawnCountdown <= 0.1 && player != null)
            {
                Instantiate(randomSeedling, transform.position, Quaternion.identity);
                initialSpawnCountdown = 15;
            }
        }

    }
}
