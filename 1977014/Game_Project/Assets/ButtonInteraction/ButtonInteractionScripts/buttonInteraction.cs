using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonInteraction : MonoBehaviour
{
    public Score score;

    public int maxHealth = 20;

    public int currentHealth;

    public Healthbar healthBar;

    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxhealth(maxHealth);
    }
    public void ScoreIncrease ()
    {
        score.IncreaseScore(100);
    }
     public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
}
