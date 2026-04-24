using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;

public class GroundCheck : MonoBehaviour {
    public PlayerMove pm;
    public BouncingController bc;


/*
 private void OnTriggerEnter2D(Collider2D collider) {
        // Check if the player is on the ground
        Debug.Log("TriggerEnter");
        if (collider.gameObject.CompareTag("Ground") || collider.gameObject.CompareTag("Grabbable")) {
            Debug.Log("TriggerTag");
            if(bc.bouncy <= 0) {
                pm.OnGround(true);
                Debug.Log("OnGround");
            } else {
                bc.SetCurrentGround(collider);
                Debug.Log("SetCurrentGround");
                // bc.Bounce();
            }
            //pm.OnGround(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collider) {
        // Sets Grounded state to false
        pm.OnGround(false);
        Debug.Log("TriggerExit");
    }

    */



    private void OnCollisionEnter2D(Collision2D collision) {
        // Check if the player is on the ground
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Grabbable")) {
             pm.OnGround(true);
            // bc.bouncy=1;
            //print("ground or grabbable");

            // bc.Bounce();
            /*
            if(bc.bouncy <= 0) {
                pm.OnGround(true);
                // Debug.Log("pm.OnGround(true)");
            } else {
                // bc.SetCurrentGround(collision);
                // Debug.Log("SetCurrentGround "+ collision);
                //pm.OnGround(true);
                bc.Bounce();
            }
           
            */
        }

        ///if (collision.gameObject.CompareTag("Secret"))
      //  {
          //  globalSecret.changeSecretCounter(1);
       // }
    }

    private void OnCollisionExit2D(Collision2D collision) {
        pm.setMaterialBounciness(0.8f);
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Grabbable")) {
            UnityEngine.Debug.Log("CollisionExit");
             pm.OnGround(false);
        }

        // Sets Grounded state to false
        // pm.OnGround(false);
        // Debug.Log("CollisionExit");
    }
    

}
