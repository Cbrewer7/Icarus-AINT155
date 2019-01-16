using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {

    public float damage = 1;
    public float speed;
    private Transform playerPos;
    private HealthSystem player;
    
    public AudioClip explosionSound;
    public AudioSource enemySound;
    //private int enemyDef;

    public Image healthBar;

    void Start()
    {
        // Obtaining the Playersystem script variables/components
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<HealthSystem>();
        // Obtaining the Player position
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        enemySound.clip = explosionSound;
    }

    void Update()
    {
        // The Enemy automatically moving towards the Player
        if (transform.position != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);
        } else
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Where the player loses health
        if (other.CompareTag("Player"))
        {
            player.TakeDamage(damage);

            // Destroying the Enemy object
            gameObject.SetActive(false);
            // Destroy(gameObject);
            enemySound.Play();
        }

        // Destroying the Enemy with the Fireable object
        if (other.CompareTag("Fireable"))
        {
            // Destroy Projectile
            Destroy(other.gameObject);
            // Destroy Enemy
            gameObject.SetActive(false);
            //Destroy(gameObject);
            enemySound.Play();

           
            // Adding score to the enemies defeated stat
            FindObjectOfType<AddScore>().AddToEnemiesDef();


            
        }
    }

    // Used to initiate the explosion after enemy death
    private void OnDisable()
    {
        GetComponent<Spawner>().Spawn();

    }
   
}

