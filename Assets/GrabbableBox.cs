using UnityEngine;

public class GrabbableBox : MonoBehaviour {
    public GameObject player;
    public DistanceJoint2D distanceJoint;
    public LineRenderer lineRenderer;
    public Rigidbody2D rb;
<<<<<<< Updated upstream

    public float maxDistance = 300;
=======
    public float mouseDragSpeed = 10f;
    bool isGrabbed = false;

    public float maxDistance = 5;
>>>>>>> Stashed changes

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        distanceJoint.enabled = false;
        lineRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update() {
        if (lineRenderer.enabled) {
            lineRenderer.SetPosition(0, player.transform.position);
            lineRenderer.SetPosition(1, transform.position);
        }
    }

    void OnMouseDown() {
        Debug.Log(Vector2.Distance(player.transform.position, transform.position));
        if (Vector2.Distance(player.transform.position, transform.position) <= maxDistance) {
<<<<<<< Updated upstream
=======
            isGrabbed = true;
>>>>>>> Stashed changes
            distanceJoint.connectedAnchor = player.transform.position;
            distanceJoint.enabled = true;
            lineRenderer.enabled = true;
            print("mouseDown");
        }
    }

    void OnMouseUp() {
<<<<<<< Updated upstream
        distanceJoint.enabled = false;
        lineRenderer.enabled = false;
    }

    void OnMouseDrag() {
        rb.AddForce(Input.mousePositionDelta * 10f);

        if (distanceJoint.distance > maxDistance) {
=======
        isGrabbed = false;
        distanceJoint.enabled = false;
        lineRenderer.enabled = false;
        print("Let go");
    }

    void OnMouseDrag() {
        if (isGrabbed == true) {
                    rb.AddForce(Input.mousePositionDelta * mouseDragSpeed);
        }

      if (Vector2.Distance(player.transform.position, transform.position) > maxDistance) {
            print("Too far");
            isGrabbed = false;
             distanceJoint.enabled = false;
            lineRenderer.enabled = false;
>>>>>>> Stashed changes
            //transform.position = curPosition;
            //print("ouchie");
        }
    }
}