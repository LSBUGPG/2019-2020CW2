using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    public float jumpForce = 5f;
    public float moveForce = 5f;

    


    void Start()
    {
        rb = GetComponent<Rigidbody>();

        
    }


    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Joystick1Button1) || Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);

        }


        if (Input.GetAxis("Horizontal") > 0)
        {
            rb.AddForce(new Vector3(-moveForce, 0, 0), ForceMode.Impulse);

        }

        else if (Input.GetAxis("Horizontal") < 0)
        {
            rb.AddForce(new Vector3(moveForce, 0, 0), ForceMode.Impulse);

        }


        if (Input.GetAxis("Vertical") > 0)
        {
            rb.AddForce(new Vector3(0, 0, moveForce), ForceMode.Impulse);

        }

        else if (Input.GetAxis("Vertical") < 0)
        {
            rb.AddForce(new Vector3(0, 0, -moveForce), ForceMode.Impulse);

        }


       



    }
}
