using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Playersystem : MonoBehaviour {

    // used to apply multiple animations
    public Animator anim;
    // Contorlling the speed of player
    public float Speed = 3;
    private Vector2 moveVelocity;
    private Rigidbody2D rb;
    //public Image healthBar;
    //public Text HealthDisplay;
    private int pickupCount;

    private static bool playerExists;

    

    // Use this for initialization
    void Start() {
    rb = GetComponent<Rigidbody2D>();
    anim = GetComponent<Animator>();

    //If player exists is not true
    if (!playerExists)
    {
        playerExists = true;
        // The Player will remain the same when changing scenes
        DontDestroyOnLoad(transform.gameObject);
    }
    else
    {
        // Destroys the copy of the player object that appears when a new scene is loaded
        Destroy(gameObject);
    }

        pickupCount = 0;
    }

    // Update is called once per frame
    void Update() {
       


        // Player movement
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moveVelocity = moveInput.normalized * Speed;

        // Change the below to When the player Dies Display the stats

        // If the Player Health reaches 0 or less then the level restarts (THIS IS TEMPORARY) 
        //if(health <= 0)
        //{
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        // }




        // Used to assign animation
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        anim.SetFloat("SpeedX", inputX);
        anim.SetFloat("SpeedY", inputY);


    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);

        // Used to assign the axis for the animation
        float lastInputX = Input.GetAxis("Horizontal");
        float lastInputY = Input.GetAxis("Vertical");

        // Checking if the player is moving to call the animation and set it to true
        if (lastInputX != 0 || lastInputY != 0)
        {
            anim.SetBool("Moving", true);
            if (lastInputX > 0)
            {
                anim.SetFloat("LastMoveX", 1f);
            } else if (lastInputX < 0)
            {
                anim.SetFloat("LastMoveX", -1f);
            } else
            {
                anim.SetFloat("LastMoveX", 0f);
            }

            if (lastInputY > 0)
            {
                anim.SetFloat("LastMoveY", 1f);
            } else if (lastInputY < 0)
            {
                anim.SetFloat("LastMoveY", -1f);
            } else
            {
                anim.SetFloat("LastMoveY", 0f);
            }
        }
        else
        {
            anim.SetBool("Moving", false);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            pickupCount = pickupCount + 1;
            
        }
    }
}
