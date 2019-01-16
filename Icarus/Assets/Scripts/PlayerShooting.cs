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
        // When the player clicks the mouse the shot is started and goes to 
        // the direction of the mouse click from the players position.
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(shot, PlayerPos.position, Quaternion.identity);
            // Adding a sound effect
            Playerfiring.Play();
        }    
    }
}
