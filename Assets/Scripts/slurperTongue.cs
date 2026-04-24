using System;
using UnityEngine;

public class slurperTongue : MonoBehaviour {
    public LineRenderer lr;
    
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("Box")) {
            lr.enabled = true;
            lr.SetPosition(0, this.transform.position);
            lr.SetPosition(1, other.transform.position);
        }
    }

    void OnTriggerStay2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("Box")) {
            lr.SetPosition(0, this.transform.position);
            lr.SetPosition(1, other.transform.position);
        }
    }
    
    void OnTriggerExit2D(Collider2D other) {
        lr.enabled = false;
    }
}
