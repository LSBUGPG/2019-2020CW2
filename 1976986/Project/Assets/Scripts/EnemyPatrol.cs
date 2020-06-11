using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public GameObject checkleft;
    private bool hitLeft;
    public GameObject checkright;
    private bool hitRight;
    public LayerMask ground;
    private Rigidbody2D rb;
    public float speed;
    private float currentspeed;
    // Start is called before the first frame update
    void Start()
    {
        Physics2D.IgnoreLayerCollision(10, 10);
        rb = GetComponent<Rigidbody2D>();
        currentspeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        
        rb.velocity = transform.right * speed;
        hitRight = Physics2D.Raycast(checkright.transform.position, Vector2.right, 0.1f, ground);
        if (hitRight == true)
        {
            transform.Rotate(0, 180, 0);
        }
    }
}
