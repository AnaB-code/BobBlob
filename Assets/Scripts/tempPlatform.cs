using UnityEngine;

public class tempPlatform : MonoBehaviour {
    public float lifetime;
    void Start() {
        lifetime = 5f;
    }

    void Update() {
        if (lifetime < 0) {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionStay2D(Collision2D other) {
        Debug.Log(lifetime);
        if (other.gameObject.CompareTag("Player")) {
            lifetime -= Time.deltaTime;
        }
    }
}