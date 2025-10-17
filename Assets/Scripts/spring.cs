using UnityEngine;

public class spring : MonoBehaviour {
    public float jumpForce;
    void Start() {
        
    }

    void Update() {

    }

    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.CompareTag("Player")) {
            other.gameObject.GetComponent<PlayerMove>().SetBounce(jumpForce);
            
        }
    }
}
