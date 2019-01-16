using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class OnDamagedEvent : UnityEvent<int> { }

public class HealthSystem : MonoBehaviour {

    public static float health = 10f;

    // UI to display the player health
    public Image HealthBar;
    public Text HealthDisplay;
    
    private void Update()
    {
        // Update the text box to display the current health
        HealthDisplay.text = "Health: " + health;
        HealthBar.fillAmount = health / 10f;
    }

    // Where the Player will take damage and the sequence after their health reaches 0
    public void TakeDamage(float amount)
    {
        health -= amount;
        HealthBar.fillAmount = health / 10f;

        if (health <= 0)
        {
            // Load Death Screen when health reaches 0 
            SceneManager.LoadScene("OnDeath");
            
            // Make the score calculation when the player dies
            FindObjectOfType<AddScore>().AddToScore();

            // Resets the players health to 10
            health = health + 10;
        }
    }

    // Called upon to add health to the player
    public void RecieveHealth(float amount){

        health += amount;
        HealthBar.fillAmount = health / 10f;

        if (health >= 10)
        {
            health = 10;
        }
    }
}
