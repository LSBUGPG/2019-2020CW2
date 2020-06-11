using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform groundcheck;
    public LayerMask ground;
    public float speed;
    private bool grounded = false;
    public float jumpHeight;
    private bool candoublejump;
    private bool left = true;
    public int currentHealth;
    public int maxHealth;
    private int damagetaken;
    public GameObject deathscreen;
    private void Start()
    {
        Time.timeScale = 1;
        currentHealth = maxHealth;
    }

    void FixedUpdate()
    {
        //Groundcheck raycast
        grounded = Physics2D.Raycast(groundcheck.transform.position, Vector2.down, 0.1f, ground);
        //Move right
        if (Input.GetAxis("Horizontal") > 0)
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
            if (left == false)
            {
                charFlip();
                left = true;
            }
        }
        //Move left
        else if (Input.GetAxis("Horizontal") < 0)
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
            if (left == true)
            {
                charFlip();
                left = false;
            }
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }

    }
    private void Update()
    {
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        if (/*Input.GetAxis("Vertical") > 0||*/Input.GetKeyUp(KeyCode.Space))
        {
            Jump();
        }
    }

    private void charFlip()
    {
        transform.Rotate(0, 180, 0);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "enemy")
        {
            damagetaken = other.gameObject.GetComponent<EnemyHealth>().damagetoplayer;
            currentHealth -= damagetaken;
        }
        if (other.gameObject.tag == "enemybullet")
        {
            damagetaken = other.gameObject.GetComponent<Bullet>().damage;
            currentHealth -= damagetaken;
        }
        if (currentHealth <= 0)
        {
            deathscreen.SetActive(true);
            Time.timeScale = 0;
            Destroy(gameObject);
        }
    }
    public void Jump()
    {
        if (grounded == true)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
            candoublejump = true;
        }
        else if (candoublejump == true)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
            candoublejump = false;
        }
    }
}
