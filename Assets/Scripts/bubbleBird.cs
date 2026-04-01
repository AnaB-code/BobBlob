using UnityEditor;
using UnityEngine;

public class bubbleBird : MonoBehaviour {
    public GameObject bubblePrefab;
    private float timeLeftToNextInstantiation;
    public float spawnRate;
    public Vector2 offset;
    public bool bubbleExists;

    public Vector2 prefabVelocity;
    
    void Start() {
        timeLeftToNextInstantiation = spawnRate;
    }
    void Update() {
        GameObject existingBubble = GameObject.Find("Bubble(Clone)");

        if (!bubbleExists) {
            timeLeftToNextInstantiation -= Time.deltaTime;
            if (timeLeftToNextInstantiation <= 0) {
                GameObject newBubble = GameObject.Instantiate(bubblePrefab, new Vector2(transform.position.x + offset.x, transform.position.y + offset.y),
                    transform.rotation) as GameObject;
                newBubble.GetComponent<tempPlatform>().velocity = prefabVelocity;
                newBubble.GetComponent<tempPlatform>().sourceBird = this.gameObject;
                timeLeftToNextInstantiation = spawnRate;
                bubbleExists = true;
            }
        }
    }
}
