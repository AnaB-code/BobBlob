using UnityEngine;

public class spring : MonoBehaviour {
    public float jumpForceX;
    public float jumpForceY;

    public AudioSource audioSource;

    public AudioClip bounce;
    
    void OnCollisionEnter2D(Collision2D other) {
        
        if (other.gameObject.CompareTag("Player")) {
            other.gameObject.GetComponent<PlayerMove>().SetBounce(jumpForceX, jumpForceY);
            audioSource.clip = bounce;
            audioSource.Play();
            
        }
    }
}
