using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public PlayerMove pm;
    public BouncingController bc;

    private void OnCollisionEnter2D(Collision2D collision) {
        // Check if the player is on the ground
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Grabbable")) {
            if(bc.bouncy == 0) {
                pm.OnGround(true);
            } else {
                bc.SetCurrentGround(collision);
                bc.Bounce(collision);
            }
            //pm.OnGround(true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision) {
        // Sets Grounded state to false
        pm.OnGround(false);
    }
}
