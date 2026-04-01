using UnityEngine;

public class tempPlatform : MonoBehaviour {
    public float lifetime;
    public Vector2 velocity;
    public GameObject sourceBird;
    void Start() {
        lifetime = 5f;
    }

    void Update() {
        if (lifetime < 0) {
            sourceBird.GetComponent<bubbleBird>().bubbleExists = false;
            Destroy(this.gameObject);
        }
        transform.position = Vector2.Lerp(transform.position, velocity, Time.deltaTime);
    }

    void OnCollisionStay2D(Collision2D other) {
        Debug.Log(lifetime);
        if (other.gameObject.CompareTag("Player")) {
            lifetime -= Time.deltaTime;
        }
    }
}