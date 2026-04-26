using System;
using UnityEngine;

public class slurperTongue : MonoBehaviour {
    public LineRenderer lr;
    public AudioSource audioSource;
    public AudioClip latch;
    public AudioClip reel;
    
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("Box")) {
            lr.enabled = true;
            lr.SetPosition(0, this.transform.position);
            lr.SetPosition(1, other.transform.position);
           audioSource.clip = reel;
           audioSource.Play();

        }
    }

    void OnTriggerStay2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("Box")) {
            lr.SetPosition(0, this.transform.position);
            lr.SetPosition(1, other.transform.position);
            audioSource.clip = latch;
            audioSource.Play();
            
        }
    }
    
    void OnTriggerExit2D(Collider2D other) {
        lr.enabled = false;
    }
}