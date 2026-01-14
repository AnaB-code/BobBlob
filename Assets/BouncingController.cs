using UnityEngine;

public class BouncingController : MonoBehaviour
{
    public Rigidbody2D player;
    public PlayerMove pm;
    public float bouncy = 1;
    public GameObject surface1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player.sharedMaterial.bounciness = 0;
        player.sharedMaterial = player.sharedMaterial;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetCurrentGround(Collision2D other)
    {
        if (surface1 == null)
        {
            surface1 = other.gameObject;
            bouncy = 1;
            player.sharedMaterial.bounciness = bouncy;
            player.sharedMaterial = player.sharedMaterial;
        }
        else if (surface1 == other.gameObject)
        {
            Bounce(other);
        }
        else if (surface1 != other.gameObject)
        {
            surface1 = other.gameObject;
            bouncy = 1;
            player.sharedMaterial.bounciness = bouncy;
            player.sharedMaterial = player.sharedMaterial;
        }
    }

    public void Bounce(Collision2D other)
    {
        bouncy = bouncy - 0.1f;

        if (bouncy < 0.2)
        {
            bouncy = 0;
            pm.OnGround(true);
        }

        player.sharedMaterial.bounciness = bouncy;
        player.sharedMaterial = player.sharedMaterial;
    }
}
