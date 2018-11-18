using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // used to apply multiple animations
    public Animator anim;
    // Contorlling the speed of player
    public float Speed = 3;
    private Vector2 moveVelocity;
    private Rigidbody2D rb;

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

        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        anim.SetFloat("SpeedX", inputX);
        anim.SetFloat("SpeedY", inputY);
	}

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
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
