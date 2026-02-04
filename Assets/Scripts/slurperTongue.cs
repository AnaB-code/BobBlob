using System;
using UnityEngine;

public class slurperTongue : MonoBehaviour {
    public LineRenderer lr;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }


    private void OnTriggerEnter2D(Collider2D other) {
        //Debug.Log("I found a yummy " + other.gameObject.name);
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
