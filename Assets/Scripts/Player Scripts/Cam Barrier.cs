using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamBarrier : MonoBehaviour {
    public float leftLimit;
    public float rightLimit;
    public float ceilingLimit;
    public float floorLimit;

    public Transform Player;
    public Transform cam;
    public Vector3 move;

    // Start is called before the first frame update
    void Start() {
        move.x = cam.position.x;
    }

    // Update is called once per frame
    void Update() {
        move.x = Player.position.x;
        move.y = Player.position.y;

        /*if (move.x < leftLimit) {
            move.x = leftLimit;
        }
        if (move.x > rightLimit) {
            move.x = rightLimit;
        }

        if (move.y < floorLimit) {
            move.y = floorLimit;
        }
        if (move.y > ceilingLimit) {
            move.y = ceilingLimit;
        }*/

        cam.position = move;
    }
}
