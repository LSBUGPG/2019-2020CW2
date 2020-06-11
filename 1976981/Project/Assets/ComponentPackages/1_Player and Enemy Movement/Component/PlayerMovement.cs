using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	
	public float speed;
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
        rb.velocity =  
            Vector3.up * rb.velocity.y +  
            rb.transform.right * Input.GetAxis("Horizontal") * speed + 
            rb.transform.forward * Input.GetAxis("Vertical")* speed; 
  

        if(Input.GetButtonDown("Jump")) 
        { 
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z); 
        } 

    } 
}

