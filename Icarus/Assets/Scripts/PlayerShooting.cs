using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour {

    public GameObject shot;
    private Transform PlayerPos;

    private void Start()
    {
        PlayerPos = transform;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(shot, PlayerPos.position, Quaternion.identity);
        }    
    }
}
