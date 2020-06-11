using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthCollect : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            
            other.gameObject.GetComponent<PlayerHealthSystem>().TakeDamage(-5);
            Destroy(gameObject);

        }
    }
}
