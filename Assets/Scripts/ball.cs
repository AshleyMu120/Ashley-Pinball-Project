using UnityEngine;
using UnityEngine.UI;

public class ball : MonoBehaviour
{
    public float initialSpeed = 5f; // Initial speed of the ball

    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.linearVelocity = new Vector2(initialSpeed, initialSpeed); //  initial velocity
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        string tag = collision.gameObject.tag;
        Debug.Log("Collision detected with tag: " + tag);
        switch(tag)
        {
            case "slider":
                Debug.Log("Collision with slider detected");
                GameManeger.instance.UpdateScore(2, 1);
                break;

            case "bumper":
                Debug.Log("Collision with bumper detected");
                GameManeger.instance.UpdateScore(2, 1);
                break;

            case "wheel":
                Debug.Log("Collision with wheel detected");
                GameManeger.instance.UpdateScore(2, 1);
                break;

            case "speed":
                Debug.Log("Collision with speed detected");
                GameManeger.instance.UpdateScore(5, 1);
                break;

            case "mashmallow":
                Debug.Log("Collision with mashmallow detected");
                GameManeger.instance.UpdateScore(10, 1);
                break;

            case "bouncer":
                Debug.Log("Collision with bouncer detected");
                GameManeger.instance.UpdateScore(2, 1);
                break;

            case "Star":
                Debug.Log("Collision with Star detected");
                GameManeger.instance.GameEnd();
                break;

            default:
                break;
        }
    }
}