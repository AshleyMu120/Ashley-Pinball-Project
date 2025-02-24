using UnityEngine;

public class mashmallow : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball")) 
        {
            if (spriteRenderer != null)
            {
                spriteRenderer.enabled = false; 
            }
            Destroy(gameObject); 
        }
    }
}