using UnityEngine;

public class Grappler : MonoBehaviour
{
    public Camera mainCamera;
    public LineRenderer lineRenderer;
    public DistanceJoint2D distanceJoint;
<<<<<<< Updated upstream
    PlayerMove playerMoveScript;

    public string grab = null;
=======
    public float maxGrappleDistance = 10;
    PlayerMove playerMoveScript;

    // public string grab = null;
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
        if (grab == "Grabbable" || grabbing == true)
        {
            Grab();
        }
    }

    void Grab()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = (Vector2)mainCamera.ScreenToWorldPoint(Input.mousePosition);
=======
        // if (grab == "Grabbable") 
        // {
        //     Grab();
        // }


if (Input.GetMouseButtonDown(0) && grabbing == true )
        {
            Vector2 mousePos = (Vector2)mainCamera.ScreenToWorldPoint(Input.mousePosition);
            Vector2 myPosition = transform.position;

            if( Vector2.Distance(myPosition, mousePos)  < maxGrappleDistance)
            {
>>>>>>> Stashed changes
            lineRenderer.SetPosition(0, mousePos);
            lineRenderer.SetPosition(1, transform.position);
            distanceJoint.connectedAnchor = mousePos;
            distanceJoint.enabled = true;
            lineRenderer.enabled = true;
            grabbing = true;
            playerMoveScript.SetUseForce(true);
<<<<<<< Updated upstream
        }

        else if (Input.GetMouseButtonUp(0))
=======
          }     
        }


        if (Input.GetMouseButtonUp(0))
>>>>>>> Stashed changes
        {
            distanceJoint.enabled = false;
            lineRenderer.enabled = false;
            grabbing = false;
            playerMoveScript.SetUseForce(false);
        }

<<<<<<< Updated upstream
        if (distanceJoint.enabled)
        {
            lineRenderer.SetPosition(1, transform.position);
        }
    }

    public void SetGrab(string g)
    {
        grab = g;
    }
=======
                if (distanceJoint.enabled)
        {
            lineRenderer.SetPosition(1, transform.position);
        }

        //Debug.Log(Vector2.Distance(player.transform.position, transform.position));
    }

    // void Grab()
    // {
    //     // if (Input.GetMouseButtonDown(0))
    //     // {
    //     //     Vector2 mousePos = (Vector2)mainCamera.ScreenToWorldPoint(Input.mousePosition);
    //     //     Vector2 myPosition = transform.position;

    //     //     if( Vector2.Distance(myPosition, mousePos)  < maxGrappleDistance)
    //     //     {
    //     //     lineRenderer.SetPosition(0, mousePos);
    //     //     lineRenderer.SetPosition(1, transform.position);
    //     //     distanceJoint.connectedAnchor = mousePos;
    //     //     distanceJoint.enabled = true;
    //     //     lineRenderer.enabled = true;
    //     //     grabbing = true;
    //     //     playerMoveScript.SetUseForce(true);
    //     //   }     
    //     // }

    //     // else if (Input.GetMouseButtonUp(0))
    //     // {
    //     //     distanceJoint.enabled = false;
    //     //     lineRenderer.enabled = false;
    //     //     grabbing = false;
    //     //     playerMoveScript.SetUseForce(false);
    //     // }

    //     // if (distanceJoint.enabled)
    //     // {
    //     //     lineRenderer.SetPosition(1, transform.position);
    //     // }
    // }

    public void Grabbed(bool detectMouseGrabbed)
    {
        grabbing = detectMouseGrabbed;
        print("grabbing = " + grabbing);
    }

    // public void SetGrab(string g)
    // {
    //     grab = g;
    //     print("g = " + g);
    // }
>>>>>>> Stashed changes
}
