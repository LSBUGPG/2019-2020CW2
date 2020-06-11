using UnityEngine;

public class Target : MonoBehaviour
{
    public int health = 50;

    public HealthBar healthBar;

    public void TakeDamage (int amount)
    {
        health -= amount;
        healthBar.SetHealth(health);
        if(health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
