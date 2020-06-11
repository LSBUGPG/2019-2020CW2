using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{

    private string MoveInputAxis = "Vertical";
    private string TurnInputAxis = "Horizontal";

    public float rotationRate = 360;

    public float moveRate = 10;

    private Rigidbody rb;

    public float jumpForce = 7;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float moveAxis = Input.GetAxis(MoveInputAxis);
        float turnAxis = Input.GetAxis(TurnInputAxis);

        ApplyInput(moveAxis, turnAxis);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    private void ApplyInput(float moveInput,
                            float turnInput)
    {
        Move(moveInput);
        Turn(turnInput);
    }

    private void Move(float input)
    {
        rb.AddForce(transform.forward * input * moveRate, ForceMode.Force);
    }

    private void Turn(float input)
    {
        transform.Rotate(0, input * rotationRate * Time.deltaTime, 0);
    }
}