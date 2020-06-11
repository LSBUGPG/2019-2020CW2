using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int maxHealth = 20;

    public int currentHealth;

    public Healthbar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxhealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(2);
        }
    }

    void TakeDamage(int damage) 
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
}
