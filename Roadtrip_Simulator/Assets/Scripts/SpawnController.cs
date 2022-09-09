using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject crate;
    public GameObject powerup;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCrateWave", 0.1f, 0.5f);
        InvokeRepeating("SpawnPowerup", 15f, 15f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnCrateWave()
    {
        Instantiate(crate, RandomSpawnTruckPosition(), Quaternion.Euler(crate.transform.rotation.x, Random.Range(-30,30), crate.transform.rotation.z));
        // chce miec kilka pudel w jednej fali (jedno wywolanie = wiele pudel)
        // ilosc pudel na odwolanie ma sie robic wieksza z uplywem gry
        // na podstawie licznika punktow moze?
        // to z czasem chyba xd
    }

    void SpawnPowerup()
    {
        Instantiate(powerup, RandomSpawnTruckPosition(), crate.transform.rotation);
        // chcialbym, zeby powerup pojawial sie jako nagroda lub w momencie
        // kiedy generator pierdolnie duzo skrzynek
    }

    Vector3 RandomSpawnTruckPosition()
    {
        int randomTruckX = Random.Range(-2, 3) * 5;

        Vector3 randomTruck = new Vector3(randomTruckX, 3, 64);

        return randomTruck;
    }
}

// Z axis 64, 1 of 5 trucks (X axis -10, -5, 0, 5, 10)
// random array
// with time i want more randomness
// first only one crate at a time, in the end they can spawn either
// in 4 trucks in the same time, or just by 2 at a time but very frequently
