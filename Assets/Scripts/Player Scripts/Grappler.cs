using UnityEngine;

public class Grappler : MonoBehaviour
{
    public Camera mainCamera;
    public LineRenderer lineRenderer;
    public DistanceJoint2D distanceJoint;
    PlayerMove playerMoveScript;

    public string grab = null;
    public bool grabbing = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerMoveScript = GetComponent<PlayerMove>();
        distanceJoint.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (grab == "Grapplable" || grabbing == true)
        {
            Grab();
        }
    }

    void Grab()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = (Vector2)mainCamera.ScreenToWorldPoint(Input.mousePosition);
            lineRenderer.SetPosition(0, mousePos);
            lineRenderer.SetPosition(1, transform.position);
            distanceJoint.connectedAnchor = mousePos;
            distanceJoint.enabled = true;
            lineRenderer.enabled = true;
            grabbing = true;
            playerMoveScript.SetUseForce(true);
            //Debug.Log("Useing force");
        }

        else if (Input.GetMouseButtonUp(0))
        {
            distanceJoint.enabled = false;
            lineRenderer.enabled = false;
            grabbing = false;
            playerMoveScript.SetUseForce(false);
            //Debug.Log("Not useing force");
        }

        if (distanceJoint.enabled)
        {
            lineRenderer.SetPosition(1, transform.position);
        }
    }

    public void SetGrab(string g)
    {
        grab = g;
    }
}
