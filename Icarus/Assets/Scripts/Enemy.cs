using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float speed;
    private Transform playerPos;
    private Playersystem player;

    void Start()
    {
        // Obtaining the Playersystem script variables/components
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Playersystem>();
        // Obtaining the Player position
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        // The Enemy automatically moving towards the Player
        transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Where the player loses health
        if (other.CompareTag("Player"))
        {
            player.health--;
            // Destroying the Enemy object
            Destroy(gameObject);
        }

        if (other.CompareTag("Fireable"))
        {
            Destroy(gameObject);
        }
    }
}
