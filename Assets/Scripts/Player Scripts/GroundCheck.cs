using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public PlayerMove pm;
    //public Rigidbody2D player;
    public BouncingController bc;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the player is on the ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            if (bc.bouncy == 0)
            {
                //pm.SetUseForce(false);
                pm.OnGround(true);
            }
            else
            {
                bc.SetCurrentGround(collision);
                bc.Bounce(collision);
            }
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        // Sets Grounded state to false
        pm.OnGround(false);
        //pm.SetUseForce(true);
    }
}
