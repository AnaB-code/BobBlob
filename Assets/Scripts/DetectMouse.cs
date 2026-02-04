using UnityEngine;

public class DetectMouse : MonoBehaviour
{
    public Grappler g;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

 void OnMouseDown() // Automatically knows it's inside the collider
    {
        Debug.Log("Mouse Down");
        g.Grabbed(true);
    }

    void OnMouseOver()
    {
        // Debug.Log("Mouse over");
        // g.SetGrab(this.tag);
    }

    void OnMouseExit()
    {
        Debug.Log("Mouse exit");
        // g.SetGrab(null);
    }
    void OnMouseUp()
    {
        Debug.Log("Mouse up");
        // g.SetGrab(null);
    }
}
