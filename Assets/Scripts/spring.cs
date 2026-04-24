using UnityEngine;

public class spring : MonoBehaviour
{
    public float bounceForce = 20f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody2D rb = collision.rigidbody;

        if (rb != null)
        {
            // Force a strong upward bounce using physics (not velocity)
            rb.AddForce(Vector2.up * bounceForce, ForceMode2D.Impulse);
        }
    }
}