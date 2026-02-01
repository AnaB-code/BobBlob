using UnityEngine;

public class GrabbableBox : MonoBehaviour {
    public GameObject player;
    public DistanceJoint2D distanceJoint;
    public LineRenderer lineRenderer;
    public Rigidbody2D rb;

    public float maxDistance = 300;

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
            distanceJoint.connectedAnchor = player.transform.position;
            distanceJoint.enabled = true;
            lineRenderer.enabled = true;
            print("mouseDown");
        }
    }

    void OnMouseUp() {
        distanceJoint.enabled = false;
        lineRenderer.enabled = false;
    }

    void OnMouseDrag() {
        rb.AddForce(Input.mousePositionDelta * 10f);

        if (distanceJoint.distance > maxDistance) {
            //transform.position = curPosition;
            //print("ouchie");
        }
    }
}