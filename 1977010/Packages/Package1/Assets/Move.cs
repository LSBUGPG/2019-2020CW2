using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float Jump = 1f;

    public bool isGrounded;
    public int fly;
    public bool canFly;

    public float movespeed = 5f;
    public Rigidbody rb;
    public float jumpForce;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(Input.GetAxis("Horizontal") * movespeed, rb.velocity.y, Input.GetAxis("Vertical") * movespeed);
        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, 0);
            isGrounded = false;
        }

        if (Input.GetButtonDown("Jump") && fly <= 4 && canFly == true)
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, 0);
            fly++;
            isGrounded = false;
        }

        if (Input.GetButtonDown("Jump") == true && isGrounded == true)
        {
            rb.velocity = new Vector3(rb.velocity.x, Jump, 0);
            isGrounded = false;
        }
        if(fly <= 4 && isGrounded == true)
        {
            fly = 0;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }
}
