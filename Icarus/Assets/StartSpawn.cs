using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSpawn : MonoBehaviour {


    public GameObject prefabToSpawn;
    public float adjustmentAngle = 0.0f;


    private void Awake()
    {
        
        Spawn();
    }

    public void Spawn()
    {
        Vector3 rotationinDegrees = transform.eulerAngles;
        rotationinDegrees.z += adjustmentAngle;

        Quaternion rotationInRadians = Quaternion.Euler(rotationinDegrees);

        Instantiate(prefabToSpawn, transform.position, rotationInRadians);
    }
}
