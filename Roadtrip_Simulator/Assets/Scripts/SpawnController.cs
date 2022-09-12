using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject crate;
    public GameObject powerup;

    
    void Start()
    {
        InvokeRepeating("SpawnCrateWave", 0.1f, 0.5f);
        InvokeRepeating("SpawnPowerup", 15f, 15f);
    }

    void SpawnCrateWave()
    {
        Instantiate(crate, RandomSpawnTruckPosition(), Quaternion.Euler(crate.transform.rotation.x, Random.Range(-30,30), crate.transform.rotation.z));
    }

    void SpawnPowerup()
    {
        Instantiate(powerup, RandomSpawnTruckPosition(), crate.transform.rotation);
    }

    // ABSTRACTION

    Vector3 RandomSpawnTruckPosition()
    {
        int randomTruckX = Random.Range(-2, 3) * 5;

        Vector3 randomTruck = new Vector3(randomTruckX, 3, 64);

        return randomTruck;
    }
}

