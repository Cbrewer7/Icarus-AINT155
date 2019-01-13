using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelDoor : MonoBehaviour {


    // Allows the ability to choose the next level in the inspector
    // rather than have mulitple scripts for the same function
    public string newLevel;

    //[SerializeField] private 

    // When the player collides with this object a new level will load
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
            SceneManager.LoadScene(newLevel);
        }
    }
    
}
