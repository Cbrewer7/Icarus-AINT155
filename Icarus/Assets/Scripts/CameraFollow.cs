using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {


    public Transform target;
    // How quick the camera movement is when following
    public float smoothing = 5.0f;

    // Alternative Camerea following application
    //public GameObject followTarget;
    //private Vector3 targetPos;
    //public float moveSpeed;

    private static bool cameraExists;

    void Start()
    {
        // Keeping the Game Camera consistent throughout the game
        // Destroying any copies of the game camera if there are any present
        if (!cameraExists)
        {
            cameraExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        // Alternative Camera Following calculation
        //target = GameObject.FindGameObjectWithTag("Player").transform;

    }

    // Use this for initialization
    void FixedUpdate()
    {
        // Finding the prefab postion and moving towards it
        Vector3 newPos = new Vector3(target.position.x, target.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, newPos, (smoothing * 0.001f));
    }

    // Alternative Camera Following calculation 
    //void Update()
    //{
    //    targetPos = new Vector3(followTarget.transform.position.x, followTarget.transform.position.y, transform.position.z);
    //    transform.position = Vector3.Lerp(transform.position, targetPos, moveSpeed * Time.deltaTime);
    //}
}
