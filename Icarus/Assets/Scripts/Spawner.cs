using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject prefabToSpawn;
    public float adjustmentAngle = 0.0f;

    public void Spawn()
    {
        Vector3 rotationinDegrees = transform.eulerAngles;
        rotationinDegrees.z += adjustmentAngle;

        Quaternion rotationInRadians = Quaternion.Euler(rotationinDegrees);

        Instantiate(prefabToSpawn, transform.position, rotationInRadians);
    }
}


/* 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject enemy;
    public Transform[] spawnSpot;
    private float timeBtwSpawns;
    public float startTimeBtwSpawns;

    void Start()
    {
        timeBtwSpawns = startTimeBtwSpawns;
    }


    void Update()
    {

        if (timeBtwSpawns <= 0)
        {
            int randPos = Random.Range(0, spawnSpots.Length - 1);
            Instantiate(enemy, spawnSpots[randPos], Quaternion.identity);
            timeBtwSpawns = 2;
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }
    }
}
*/
