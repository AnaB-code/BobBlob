using UnityEngine;

public class Bullet : MonoBehaviour {
    public float velocity;
    public float lifetime;
    public DieAndRespawnn killScript;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        killScript.player = GameObject.FindGameObjectWithTag("Player");
        killScript.respawnPoint = GameObject.Find("RespawnPoint");
    }

    // Update is called once per frame
    void Update() {
        transform.Translate(new Vector3(velocity * Time.deltaTime, 0, 0));
        lifetime -= Time.deltaTime;

        if (lifetime <= 0) {
            Destroy(this.gameObject);
        }
    }
}
