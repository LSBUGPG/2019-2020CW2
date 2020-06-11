using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 moveVector;
    
    private float speed = 8.0f;
    private float verticalVelocity = 0.0f;
    private float gravity = 12.0f;

    private bool isDead = false;

    private float animationDuration = 3.0f;

    void Start() {
        controller = GetComponent<CharacterController>();
    }

    void Update() {

        if (isDead)
            return;

        if(Time.time < animationDuration) 
        {
            controller.Move(Vector3.forward * speed * Time.deltaTime);
            return;
        }

        moveVector = Vector3.zero;

        if (controller.isGrounded) 
        {
            verticalVelocity = -0.5f;
        }
        else 
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }

        
        moveVector.x = Input.GetAxisRaw("Horizontal") * speed;
        moveVector.y = verticalVelocity;
        moveVector.z = speed;

        controller.Move (moveVector * Time.deltaTime); 
    }

    public void SetSpeed(float modifier)
    {
        speed = 8.0f + modifier;
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.point.z > transform.position.z + controller.radius)
            Death();
    }

    private void Death()
    {
        isDead = true;
        GetComponent<Score>().OnDeath();
    }
}
