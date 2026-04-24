using UnityEditor;
using UnityEngine;

public class Firearm : MonoBehaviour {
    public GameObject bulletPrefab;
    private float timeLeftToNextInstantiation;
    public float fireRate;
    public Vector2 offset;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        timeLeftToNextInstantiation = fireRate;
    }

    // Update is called once per frame
    void Update() {
        timeLeftToNextInstantiation -= Time.deltaTime;
        if(timeLeftToNextInstantiation <= 0) {
            Instantiate(bulletPrefab, new Vector2(transform.position.x + offset.x, transform.position.y + offset.y),  transform.rotation);
            timeLeftToNextInstantiation = fireRate;
        }
    }
}
