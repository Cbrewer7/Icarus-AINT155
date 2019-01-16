using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonCollectable : MonoBehaviour {

    
    // Getting the audio object source and the actual audio clip
    public AudioClip balloonPop;
    private AudioSource balloonCollected;
   
        
    // Use this for initialization
	void Start () {

        // DOES NOT WORK
        // Assigns audio clip to source object to be handled
        balloonCollected = GetComponent<AudioSource>();
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Where the player comes into contact
        if (other.CompareTag("Player"))
        {
            
            FindObjectOfType<AddScore>().AddToCollectablesFound();


            // DOES NOT WORK
            //Play auido
            balloonCollected.PlayOneShot(balloonPop, 0.2f);
            balloonCollected.Play();

            // Destroying the gameobject
            gameObject.SetActive(false);
            Destroy(gameObject);
        }

    }


}
