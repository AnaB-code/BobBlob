using UnityEngine;

public class spring : MonoBehaviour
{
    public float bounceForce = 20f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody2D rb = collision.rigidbody;

    public AudioClip bounce;
    
    void OnCollisionEnter2D(Collision2D other) {
        
        if (other.gameObject.CompareTag("Player")) {
            other.gameObject.GetComponent<PlayerMove>().SetBounce(jumpForceX, jumpForceY);
            audioSource.clip = bounce;
            audioSource.Play();
            
        }
    }
}