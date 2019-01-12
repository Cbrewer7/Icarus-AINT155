using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour {

    private Playersystem thePlayer;
    private CameraFollow theCamera;

	// Use this for initialization
	void Start () {
        // Will find the game object with the Playersystem scrip attached
        // (the Player) and will move them onto the starting point
        thePlayer = FindObjectOfType<Playersystem>();
        thePlayer.transform.position = transform.position;

        // Ensuring the Camera also starts at the start point with the Player object
        theCamera = FindObjectOfType<CameraFollow>();
        theCamera.transform.position = new Vector3(transform.position.x, transform.position.y, theCamera.transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
