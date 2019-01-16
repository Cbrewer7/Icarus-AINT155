using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickupSystem : MonoBehaviour {

    private HealthSystem player;
    public float addhealth = 1;

    private void Start()
    {
        //Acquires the health system script from the player
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<HealthSystem>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // If the player collides with the object then 1 health will be added to the player 
        // through the RecieveHealth method
        if (other.CompareTag("Player"))
        {
            player.RecieveHealth(addhealth);

            Destroy(gameObject);
        }
    }


}
