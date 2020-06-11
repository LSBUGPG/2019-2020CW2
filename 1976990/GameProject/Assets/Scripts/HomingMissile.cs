using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class HomingMissile : MonoBehaviour
{
    public Transform target;
    private Rigidbody rb;
    public float speed = 4f;
    public float rotateSpeed = 200f;
    public float followStrength;
    [SerializeField]private  float rotationForce;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 direction = target.position - rb.position;
        direction.Normalize();

        Vector3 rotateAmount = Vector3.Cross(transform.up, direction);
        Debug.Log(rotateAmount);
        if (Mathf.Abs(rotateAmount.z) < followStrength) // makes it possible to dodge
        {
            rb.angularVelocity = rotateAmount * rotationForce;
        } else
        {
            rb.angularVelocity = Vector3.zero;
        }
        
        rb.velocity = transform.up * speed;
    }

    private void OnCollisionEnter(Collision other) {
        Destroy(gameObject);
    }
}
