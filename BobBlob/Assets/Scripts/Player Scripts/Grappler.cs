using UnityEngine;

public class Grappler : MonoBehaviour  {
    public Camera mainCamera;
    public LineRenderer lineRenderer;
    public DistanceJoint2D distanceJoint;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        distanceJoint.enabled = false;
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            Vector2 mousePos = (Vector2)mainCamera.ScreenToWorldPoint(Input.mousePosition);
            lineRenderer.SetPosition(0, mousePos);
            lineRenderer.SetPosition(1, transform.position); 
            distanceJoint.connectedAnchor = mousePos;
            distanceJoint.enabled = true; 
            lineRenderer.enabled = true;
        } else if (Input.GetKeyUp(KeyCode.Mouse0)) {
            distanceJoint.enabled = false;
            lineRenderer.enabled = false;
        }
        if (distanceJoint.enabled) {
            lineRenderer.SetPosition(1, transform.position);
        }
    }
}
