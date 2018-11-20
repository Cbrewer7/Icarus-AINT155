﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour {

    public float health = 10f;

    public Image HealthBar;

    public void TakeDamage(float amount)
    {
        health -= amount;

        HealthBar.fillAmount = health / 100f;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
