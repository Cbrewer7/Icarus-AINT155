using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {


    
    public float speed = 100f;

    private void Start()
    {

        // Depending on the distance of the mouse from the player, the projectile speed changes.
        // This allows the projectile to fire in the direction of the mouse click at a speed related
        // to the distance of the mouse click from the player. 
        // Fires the projectile allowing player to have animation and not be facing a specific way.
        // https://answers.unity.com/questions/604198/shooting-in-direction-of-mouse-cursor-2d.html

        Vector3 shootDirection;
        shootDirection = Input.mousePosition;
        shootDirection.z = 0.0f;
        shootDirection = Camera.main.ScreenToWorldPoint(shootDirection);
        shootDirection = shootDirection - transform.position;

        GetComponent<Rigidbody2D>().AddForce(shootDirection * speed, ForceMode2D.Impulse);

        
    }

    // Destroys the projectile after it's gone off the screen
    // FIX
    private void OnBecameInvisible()
    {
       Die();
    }

    private void Die()
    {
        Destroy(gameObject);
    }


}
