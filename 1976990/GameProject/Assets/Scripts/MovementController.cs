using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    Rigidbody rb;
    public int moveSpeed = 5;
    float moveX;
    float moveY;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
        transform.position += new Vector3(moveX * moveSpeed * Time.deltaTime, 0, moveY * moveSpeed * Time.deltaTime);
    }
}
