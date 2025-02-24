using UnityEngine;

public class speed : MonoBehaviour
{
    public float speedBoost = 2f; 
    public float moveSpeed = 2f; 
    public float minX = -1.5f; 
    public float maxX = 1.5f; 

    private Vector3 startPosition;
    private bool movingRight = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        float newX = transform.position.x + (movingRight ? moveSpeed : -moveSpeed) * Time.deltaTime;

        if (newX > maxX)
        {
            newX = maxX;
            movingRight = false;
        }
        else if (newX < minX)
        {
            newX = minX;
            movingRight = true;
        }

        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }


}