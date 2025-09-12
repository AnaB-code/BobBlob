using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testPlayer : MonoBehaviour {
    public Rigidbody2D rb; //var for character controller on player

    public float speed = 4; //player speed
    public float jump = 3; //player jump force

    private Vector2 velocity; //for moving player

    private float gravity = -10f; //gravity
    public float jumpFallSpeed = 1.5f;

    private float coyoteTime = 0.2f; //amount of coyoteTime
    private float coyoteTimeCounter; //coyoteTime counter

    private float jumpBufferTime = 0.2f; //amount of jump input buffer
    private float jumpBufferCounter; //jump buffer window counter

    public bool isGrounded = false; //bool for weather player is on the ground or not

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        Move();
        //Debug.Log(velocity.y);
        //Debug.Log(jumpFallSpeed);
    }

    void Move() {
        velocity.x = speed * Input.GetAxis("Horizontal"); //gets horizontal input

        if (isGrounded == true) { //detects if player is on ground
            coyoteTimeCounter = coyoteTime; //resets counter
        } else {
            coyoteTimeCounter -= Time.deltaTime; //counts down coyote time
        }

        if (Input.GetKeyDown("space")) { //detects if space is pressed
            jumpBufferCounter = jumpBufferTime; //resets counter
            jumpFallSpeed = 1.5f;
        } else {
            jumpBufferCounter -= Time.deltaTime; //counts down buffer window
        }

        if (jumpBufferCounter > 0f && coyoteTimeCounter > 0f) { //detects if coyoteTime + jump buffer avaiable
            velocity.y = jump; //jumps
            jumpBufferCounter = 0f; //pervents double jump
        } else if (Input.GetKeyUp("space") && velocity.y > 0f) //varies jump height by if space is held vs tapped
        {
            velocity.y = velocity.y * 0.5f;
            coyoteTimeCounter = 0f; //pervents double jump
        }
        else
        {
            velocity.y += gravity * Time.deltaTime * jumpFallSpeed; //falls
        }

        if (isGrounded == true && velocity.y <= -.51f) //pervents ground clipping
        {
            velocity.y = -1.1f;
            jumpFallSpeed = 1;
        }

        rb.linearVelocity = velocity;
    }

    public void OnGround(bool yn)
    {
        isGrounded = yn;
    }
}
