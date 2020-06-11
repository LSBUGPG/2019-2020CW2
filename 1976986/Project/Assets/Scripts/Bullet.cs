using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    public int damage;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bullet"|| collision.gameObject.tag == "wall"|| collision.gameObject.tag == "enemybullet")
        {
            Destroy(gameObject);
        }
    }
}
