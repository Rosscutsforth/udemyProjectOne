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

    //Late game variables
    private float lateGameInterval = 0.2f;
    private float lateGameHourglass = 200f;
    public AudioClip lateGameMusic;
    private AudioSource audioSource;

    //Spawn decreasin and minimun spawn interval
    public float minSpawnInterval;
    public float spawnDecrease;

    public GameObject player;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = lateGameMusic;

        if(player != null)
        {
            audioSource.PlayDelayed(lateGameHourglass - 3);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            lateGameHourglass -= Time.deltaTime;

            if (spawnInterval <= 0)
            {
                Transform randomSpawnPoint = spawnPoints[UnityEngine.Random.Range(0, spawnPoints.Length)];
                GameObject randomHazard = hazards[UnityEngine.Random.Range(0, hazards.Length)];

                Instantiate(randomHazard, randomSpawnPoint.position, Quaternion.identity);

                if(lateGameHourglass > 0)  
                {
                    if (startSpawnInterval > minSpawnInterval)
                    {
                        startSpawnInterval -= spawnDecrease;
                    }

                    spawnInterval = startSpawnInterval;
                }
                else
                {
                    spawnInterval = lateGameInterval;
                }
            }
            else
            {
                spawnInterval -= Time.deltaTime;
            }

            if(lateGameHourglass == 5)
            {

            }
        }
    }
}
