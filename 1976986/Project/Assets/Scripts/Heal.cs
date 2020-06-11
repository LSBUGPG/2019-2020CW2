using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    public PlayerController HP;
    public int HPtoRecover;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            HP.currentHealth = HP.currentHealth + HPtoRecover;
            Destroy(gameObject);
        }
    }
}
