using System.Diagnostics;
using UnityEngine;

public class BouncingController : MonoBehaviour
{
    public Rigidbody2D player;
    public PlayerMove pm;
    public float bouncy = 0;
    public GameObject surface1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // player.sharedMaterial.bounciness = 0;
        // player.sharedMaterial = player.sharedMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(bouncy);
    }

    /*
        public void SetCurrentGround(Collision2D other)
        {
            if (surface1 == null)
            {
                surface1 = other.gameObject;
                bouncy = 1f;
                player.sharedMaterial.bounciness = bouncy;
                player.sharedMaterial = player.sharedMaterial;
            }
            else if (surface1 == other.gameObject)
            {
                Bounce();

            }
            else if (surface1 != other.gameObject)
            {
                surface1 = other.gameObject;
                bouncy = 1f;
                player.sharedMaterial.bounciness = bouncy;
                player.sharedMaterial = player.sharedMaterial;
            }
        }
        */

    public void Bounce()
    {
        bouncy -= 0.1f;
        print("Bounce" + bouncy);
        if (bouncy < 0.2)
        {
            bouncy = 0;
            pm.OnGround(true);
            print("Bounce ended");
        }

        // player.sharedMaterial.bounciness = bouncy;
        // player.sharedMaterial = player.sharedMaterial;
    }
}
