﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private bool canSpawnDog = true;

    public GameObject dogPrefab;
    private float spawnDelay = 1f;

    // Update is called once per frame
    void Update()
    {
        if (canSpawnDog)
        {
            // On spacebar press, send dog
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SpawnDog();
                Invoke(nameof(ResetSpawnDog), spawnDelay);
            } 
        }
        
    }
    void SpawnDog()
    {
        // Spawns dog
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        // Disables further dog spawning
        canSpawnDog = false;
    }
    private void ResetSpawnDog()
    {
        // Enables dog spawning again
        canSpawnDog = true;
    }
}
