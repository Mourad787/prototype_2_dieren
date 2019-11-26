using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class SpawnManager : MonoBehaviour
{
    public GameObject[ ] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float StartDelay = 2;
    private float spawnInterval = 1.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", StartDelay,spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal() {
            
            int animalIndex = UnityEngine.Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos = new Vector3(UnityEngine.Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
                Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        }
    }

