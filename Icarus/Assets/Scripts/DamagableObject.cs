using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagableObject : MonoBehaviour {

    private HealthSystem player;
    public float damage = 1;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<HealthSystem>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            player.TakeDamage(damage);

        }
    }
}
