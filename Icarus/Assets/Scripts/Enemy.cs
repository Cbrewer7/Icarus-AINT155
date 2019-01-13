﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {

    public float damage = 1;
    public float speed;
    private Transform playerPos;
    private HealthSystem player;

    //private int enemyDef;

    public Image healthBar;

    void Start()
    {
        // Obtaining the Playersystem script variables/components
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<HealthSystem>();
        // Obtaining the Player position
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        //enemyDef = 0;
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
            gameObject.SetActive(false);
            Destroy(gameObject);
        }

        // Destroying the Enemy with the Fireable object
        if (other.CompareTag("Fireable"))
        {
            // Destroy Projectile
            Destroy(other.gameObject);
            // Destroy Enemy
            gameObject.SetActive(false);
            Destroy(gameObject);

            //enemyDef = enemyDef + 1;

            FindObjectOfType<AddScore>().AddToEnemiesDef();
        }
    }


    private void OnDisable()
    {
        GetComponent<Spawner>().Spawn();
    }
}
