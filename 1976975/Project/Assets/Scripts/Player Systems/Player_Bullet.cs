using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>Placed on bullet prefab. Controls bullet collisions</summary>
public class Player_Bullet : MonoBehaviour
{
    private int bulletDmg;

    /// <summary>References the bullet damage from the player shooting script</summary>
    /// <example>
    ///   <code>void Start()
    /// {
    ///     bulletDmg = GameObject.Find("Player").GetComponent&lt;Player_Shooting&gt;().bulletDmg;
    /// }</code>
    /// </example>
    void Start()
    {
        bulletDmg = GameObject.Find("Player").GetComponent<Player_Shooting>().bulletDmg;
    }

    /// <summary>Called when [collision enters].</summary>
    /// <param name="collision">The collision.</param>
    /// <remarks>If the bullet collided with an enemy then add the retrieved damage amount. If it hits anything else then the bullet is destroyed</remarks>
    /// <example>
    ///   <code>private void OnCollisionEnter(Collision collision)
    /// {
    ///     if (collision.gameObject.CompareTag("Enemy"))
    ///     {
    ///         collision.gameObject.GetComponent&lt;Enemy_Health&gt;().AddDamage(bulletDmg);
    ///         Destroy(gameObject);
    ///     }
    ///
    ///     else
    ///     {
    ///         Destroy(gameObject);
    ///     }
    /// }</code>
    /// </example>
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<Enemy_Health>().AddDamage(bulletDmg);
            Destroy(gameObject);
        }

        else
        {
            Destroy(gameObject);
        }
    }
}
