using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonCollectable : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Where the player comes into content 
        if (other.CompareTag("Player"))
        {

            //gameObject.SetActive(false);

            FindObjectOfType<AddScore>().AddToCollectablesFound();

            // Destroying the gameobject
            gameObject.SetActive(false);
            Destroy(gameObject);
        }

    }


}
