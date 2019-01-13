using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class OnDamagedEvent : UnityEvent<int> { }

public class HealthSystem : MonoBehaviour {

    public static float health = 10f;

    public Image HealthBar;
    public Text HealthDisplay;

    public Slider healthSlider;

    //public OnDamagedEvent onDamaged;

    private void Update()
    {
        // Update the text box to display the current health
        HealthDisplay.text = "Health: " + health;
        HealthBar.fillAmount = health / 10f;
    }

    public void TakeDamage(float amount)
    {
        health -= amount;

        HealthBar.fillAmount = health / 10f;

        //healthSlider.value = health;

        if (health <= 0)
        {
            // Load Death Screen when health reaches 0 

            SceneManager.LoadScene("OnDeath");
            //

            FindObjectOfType<AddScore>().AddToScore();

            health = health + 10;
        }
    }

    public void RecieveHealth(float amount){

        health += amount;

        HealthBar.fillAmount = health / 10f;

        if (health >= 10)
        {
            health = 10;
        }
    }
}
