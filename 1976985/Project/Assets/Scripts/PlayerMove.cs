using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
//[RequireComponent(typeof(Animator))]
public class PlayerMove : MonoBehaviour
{

    [SerializeField] private string horizontalInputName = "";
    [SerializeField] private string verticalInputName = "";
    public float movementSpeed;

    public bool running;

    public float turnSmoothTime = 0.2f;
    public float speedSmoothTime = 0.1f;
    float speedSmoothVelocity;

    [Range(0, 1)]
    public float airControlPercent;
    [SerializeField] private float RayLength = 0;

    [SerializeField] private float walkSpeed = 0, runSpeed = 0;
    [SerializeField] private KeyCode runKey = KeyCode.X;

    [SerializeField] private KeyCode jumpKey = KeyCode.Space;
    [SerializeField] private float jumpHeight = 0;

    private Rigidbody rigidBody;
    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    private void Update()
    {        
        if (Input.GetKey(runKey) && IsGrounded() == true)
        {
            running = true;
        } else
        {
            running = false;
        }

        if (Input.GetKeyDown(jumpKey))
        {
            Jump();

        }
        

    }

    private void FixedUpdate()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        Vector2 input = new Vector2(Input.GetAxisRaw(horizontalInputName), Input.GetAxisRaw(verticalInputName));
        Vector2 inputDir = input.normalized;

        float targetSpeed = ((running) ? runSpeed : walkSpeed) * inputDir.magnitude;
        movementSpeed = Mathf.SmoothDamp(movementSpeed, targetSpeed, ref speedSmoothVelocity, GetModifiedSmoothTime(speedSmoothTime));

        Vector3 movement = new Vector3(inputDir.x, 0, inputDir.y) * movementSpeed;

        Vector3 newPosition = rigidBody.position + rigidBody.transform.TransformDirection(movement);
        rigidBody.MovePosition(newPosition);

    }


    private void Jump()
    {
        if (IsGrounded())
        {
            rigidBody.AddForce(Vector3.up * Mathf.Sqrt(jumpHeight * -2f * Physics.gravity.y), ForceMode.VelocityChange);
        }
    }

    private bool IsGrounded()
    {
        return (Physics.Raycast(transform.position, Vector3.down, RayLength));
    }

    float GetModifiedSmoothTime(float smoothTime)
    {
        if (IsGrounded())
        {
            return smoothTime;
        }

        if (airControlPercent == 0)
        {
            return float.MaxValue;
        }
        return smoothTime / airControlPercent;
    }

}
