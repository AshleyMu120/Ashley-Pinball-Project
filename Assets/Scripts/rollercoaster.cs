using UnityEngine;

public class rollercoaster: MonoBehaviour
{
    public float speedBoost = 2f; 


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball")) 
        {
            Rigidbody2D ballRigidbody = collision.gameObject.GetComponent<Rigidbody2D>();
            if (ballRigidbody != null)
            {
                ballRigidbody.linearVelocity *= speedBoost; 
            }
        }
    }
}