using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {

    public float damage = 1;
    public float speed;
    private Transform playerPos;
    private HealthSystem player;
    public Image healthBar;

    void Start()
    {
        // Obtaining the Playersystem script variables/components
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<HealthSystem>();
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
            player.TakeDamage(damage);
            // Destroying the Enemy object
            
            Destroy(gameObject);
        }

        // Destroying the Enemy with the Fireable object
        if (other.CompareTag("Fireable"))
        {
            // Destroy Projectile
            Destroy(other.gameObject);
            // Destroy Enemy
            Destroy(gameObject);
        }
    }

    private void OnDisable()
    {
        GetComponent<Spawner>().Spawn();
    }
}
