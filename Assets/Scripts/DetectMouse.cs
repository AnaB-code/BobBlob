using UnityEngine;

public class DetectMouse : MonoBehaviour {
    public Grappler g;

    void OnMouseOver() {
        //Debug.Log("Mouse on");
        g.SetGrab(this.tag);
    }

    void OnMouseExit() {
        //Debug.Log("Mouse off");
        g.SetGrab(null);
    }
}
