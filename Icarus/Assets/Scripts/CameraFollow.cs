using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {


    public Transform target;
    public float smoothing = 5.0f;

    //public GameObject followTarget;
    //private Vector3 targetPos;
    //public float moveSpeed;

    private static bool cameraExists;

    void Start()
    {
        if (!cameraExists)
        {
            cameraExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        target = GameObject.FindGameObjectWithTag("Player").transform;

    }

    // Use this for initialization
    void FixedUpdate()
    {
        Vector3 newPos = new Vector3(target.position.x, target.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, newPos, (smoothing * 0.001f));
    }

    //void Update()
    //{
    //    targetPos = new Vector3(followTarget.transform.position.x, followTarget.transform.position.y, transform.position.z);
    //    transform.position = Vector3.Lerp(transform.position, targetPos, moveSpeed * Time.deltaTime);
    //}
}
