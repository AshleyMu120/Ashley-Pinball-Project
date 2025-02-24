using UnityEngine;

public class Star : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Collision detected with: " + other.gameObject.name);
        if (other.gameObject.CompareTag("Ball"))
        {
            Debug.Log("Star collided");
            GameManeger.instance.GameEnd();
        }
    }
}