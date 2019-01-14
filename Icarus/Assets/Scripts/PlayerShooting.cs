using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour {

    public GameObject shot;
    private Transform PlayerPos;

    public AudioClip CannonFire;
    public AudioSource Playerfiring;

    private void Start()
    {
        PlayerPos = transform;
        Playerfiring.clip = CannonFire;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(shot, PlayerPos.position, Quaternion.identity);
            Playerfiring.Play();
        }    
    }
}
