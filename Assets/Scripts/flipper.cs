using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPaddle : MonoBehaviour
{
    public LeftOrRight leftOrRight;
    public float Torque;
    private Rigidbody2D rb;
    public enum LeftOrRight { Left, Right }
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        switch (leftOrRight)
        {
            case LeftOrRight.Left:
                if (Input.GetKeyDown(KeyCode.A))
                {
                    AddPaddleTorque(Torque);
                }
                break;
            case LeftOrRight.Right:
                if (Input.GetKeyDown(KeyCode.D))
                {
                    AddPaddleTorque(-Torque);
                }
                break;
        }
    }
    private void AddPaddleTorque(float torque)
    {
        rb.AddTorque(torque, ForceMode2D.Impulse);
    }
}