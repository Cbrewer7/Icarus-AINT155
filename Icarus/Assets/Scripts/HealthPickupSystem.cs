using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickupSystem : MonoBehaviour {

    private HealthSystem player;
    public float addhealth = 1;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<HealthSystem>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            player.RecieveHealth(addhealth);

            Destroy(gameObject);
        }
    }


}
