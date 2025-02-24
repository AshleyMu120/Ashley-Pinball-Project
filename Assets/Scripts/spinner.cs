using UnityEngine;

public class spinner : MonoBehaviour
{
    public float rotationSpeed = 100f; 
    public Vector3 rotationAxis = Vector3.up; 

    void Update()
    {
       
        transform.Rotate(rotationAxis.normalized * rotationSpeed * Time.deltaTime);
    }
}
