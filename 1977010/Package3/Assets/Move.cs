using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour 
{

    public bool isGrounded;

    public float movespeed = 5f;
    public Rigidbody rb;
    public float jumpForce = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
        //this is the one for movement
        rb.velocity = new Vector3(Input.GetAxis("Horizontal") * movespeed, rb.velocity.y, Input.GetAxis("Vertical") * movespeed);
        //Below is the script to jump
        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, 0);
            isGrounded = false;
        }
    }
    //for detecting the player touching the ground
    void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }
}
