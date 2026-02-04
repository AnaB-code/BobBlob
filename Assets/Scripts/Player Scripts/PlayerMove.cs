using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
    Rigidbody2D rb; //var for character controller on player
    public BouncingController bc;

    // grappling script sets this, not whether grounded etc
    public bool useForce = false; // use AddForce (grappling) or set velocity directly (movement)
    public float forceSpeed = 10; //player speed when using AddForce
    public float velSpeed = 10; //player speed when setting velocity directly
    public float jump = 5; //player jump: set relative to speed. Always uses setVelocity

    //public float jumpFallSpeed = 1.5f;

    [Min(0f)] public float coyoteTime = 0.2f; //amount of coyoteTime
    private float coyoteTimeCounter; //coyoteTime counter

    [Min(0f)] public float jumpInputTime = 0.2f; // how long you can hold jump key to increase jump height
    private float jumpInputCounter; //jump buffer window counter

    public bool isGrounded = true; //bool for weather player is on the ground or not

    //public float maxV = 0;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() {
        Move();
    }

    void Move() {
        // SetVelocity (movement) versus AddForce (while grappling)
        if (useForce) {
            // Can use one or both axes! Horiz is most realistic for swing motion,
            // but vertical helps you do 360 loops ;)  powerup?
            rb.AddForceX(forceSpeed * Input.GetAxis("Horizontal"));
            //rb.AddForceY(forceSpeed * Input.GetAxis("Vertical"));
        } else {
            // Only horiz axis (no vertical movement besides jumping)
            rb.linearVelocityX = velSpeed * Input.GetAxis("Horizontal");
        }

        if (isGrounded == true) { //detects if player is on ground
            coyoteTimeCounter = coyoteTime; //resets counters to full
            jumpInputCounter = jumpInputTime;
        } else {
            coyoteTimeCounter -= Time.deltaTime; //counts down timer
        }

        // Using GetKey so it can be held a bit longer for higher jumps
        // BUT with time limit (jumpBufferCounter)
        if (Input.GetKeyDown("space") && coyoteTimeCounter > 0f && jumpInputCounter > 0f) {
            rb.linearVelocityY = jump;
            jumpInputCounter -= Time.deltaTime;
        }

        if (Input.GetKeyUp("space")) {
            coyoteTimeCounter = 0; //resets counter, prevents further jumps
            // don't need to reset jumpInputCounter (coyoteTimeCounter will prevent jumping)
            bc.bouncy = 1;
            rb.sharedMaterial.bounciness = bc.bouncy;
            rb.sharedMaterial = rb.sharedMaterial;
        }

        if (Input.GetKeyDown(KeyCode.LeftShift)) {
            bc.bouncy = 0;
            rb.sharedMaterial.bounciness = bc.bouncy;
            rb.sharedMaterial = rb.sharedMaterial;
        }
    }

    // Don't know if OnGround is needed/used anywhere
    public void OnGround(bool yn) {
        isGrounded = yn;
    }

    public void SetBounce(float springX, float springY) {
           // rb.AddForceX(springX);

        //rb.linearVelocityX += springX; // getting overriden by movement (?)
        rb.linearVelocityY += springY;
    }
    public void SetUseForce(bool force) // So can change move method while grappling
                                        // grappler script calls this
    {
        useForce = force;
    }
}
