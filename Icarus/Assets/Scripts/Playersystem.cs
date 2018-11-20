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


    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update () {


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
}
