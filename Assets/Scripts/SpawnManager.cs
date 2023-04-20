using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject pipePrefab;
    float randomHeight = 0.5f;

    void Start()
    {
        //Pipe Start Delay 
        //first # is wait after 1st frame, second # is delay WHEN they spawn
        InvokeRepeating("SpawnPipes", 0.5f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnPipes()
    {
        //---Spawns Pipes---
        Instantiate( pipePrefab, new Vector2(10f, Random.Range(2.95f, -3.32f)), Quaternion.identity);
    }
}
