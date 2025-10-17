using UnityEngine;
using UnityEngine.Serialization;

public class movingPlatform : MonoBehaviour {
    public Vector2[] waypoints;
    private float distanceToTarget;
    private int waypointIndex = 0;
    
    public float speed;
    
    void Start() {
        
    }

    void Update() {
        distanceToTarget = Vector2.Distance(transform.position, waypoints[waypointIndex]); // Distance To Target
        //Debug.Log(distanceToTarget);
        
        if(distanceToTarget < .1) { // If close to target, cycle to next waypoint
            waypointIndex++;
            if(waypointIndex >= waypoints.Length) { // At last waypoint
                waypointIndex = 0;
            }
        } else { // Move platform
            transform.position = Vector2.Lerp(transform.position, waypoints[waypointIndex], speed * Time.deltaTime);
        }
    }
}
