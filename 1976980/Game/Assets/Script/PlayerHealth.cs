using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public int maxHealth = 50;
    public int currentHealth;

    public HealthBar healthBar;

    [SerializeField] Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void KillPlayer()
    {
        transform.position = spawnPoint.position;
        currentHealth = maxHealth;
        healthBar.SetHealth(currentHealth);
    }


    // Update is called once per frame
    void OnCollisionStay2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "Enemy")
        {
            TakeDamage(1);

            if(currentHealth < 0)
            {
                KillPlayer();
            }
        }

        if( collision.gameObject.name == "Kill Floor")
        {
            KillPlayer();
        }



    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
}
