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

    void OnMouseOver()
    {
        //Debug.Log("Mouse on");
        g.SetGrab(this.tag);
    }

    void OnMouseExit()
    {
        //Debug.Log("Mouse off");
        g.SetGrab(null);
    }
}
