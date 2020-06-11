using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMove : MonoBehaviour
{

    [SerializeField] float moveSpeed = 5f;

    float dirX, dirY;

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal") * moveSpeed;
        dirY = Input.GetAxisRaw("Vertical") * moveSpeed;
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, dirY);
    }
}
