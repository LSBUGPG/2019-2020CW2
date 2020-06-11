using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>This script is placed on the Lightning Strike prefab and controls it</summary>
public class Lightning_Strike : MonoBehaviour
{
    public float strikeSpeed;
    public int lightningDamage;

    private SphereCollider dmgArea;
    private bool hasHitGround;

    // Start is called before the first frame update
    /// <summary>Starts this instance.</summary>
    /// <remarks>References the sphere collider. Disables layer collisions with the enemies and player so that it doesn't knock them around</remarks>
    /// <example>
    ///   <code>void Start()
    /// {
    ///     dmgArea = GetComponent&lt;SphereCollider&gt;();
    ///
    ///     Physics.IgnoreLayerCollision(8, 9);
    ///     Physics.IgnoreLayerCollision(8, 8);
    /// }</code>
    /// </example>
    void Start()
    {
        dmgArea = GetComponent<SphereCollider>();

        Physics.IgnoreLayerCollision(8, 9);
        Physics.IgnoreLayerCollision(8, 8);
    }

    // Update is called once per frame
    /// <summary>Checks if Lightning hit the ground</summary>
    /// <remarks>If its hit the ground it stops moving</remarks>
    /// <example>
    ///   <code>void Update()
    /// {
    ///     if (!hasHitGround)
    ///     {
    ///         transform.position += Vector3.down * Time.deltaTime * strikeSpeed;
    ///     }
    /// }</code>
    /// </example>
    void Update()
    {
        if (!hasHitGround)
        {
            transform.position += Vector3.down * Time.deltaTime * strikeSpeed;
        }
    }

    /// <summary>Called when it collides with the ground</summary>
    /// <param name="collision">The collision.</param>
    /// <remarks>Enables the damage area and sets hit ground to true. Calls WaitToDestroy</remarks>
    /// <example>
    ///   <code>private void OnCollisionEnter(Collision collision)
    /// {
    ///     dmgArea.enabled = !dmgArea.enabled;
    ///     hasHitGround = !hasHitGround;
    ///     StartCoroutine(WaitToDestroy());
    /// }</code>
    /// </example>
    private void OnCollisionEnter(Collision collision)
    {
        dmgArea.enabled = !dmgArea.enabled;
        hasHitGround = !hasHitGround;
        StartCoroutine(WaitToDestroy());
    }

    /// <summary>Called when it triggers an enemy</summary>
    /// <param name="other">The collision</param>
    /// <remarks>If it triggers against an enemy then calls AddDamage and add the lightning damage</remarks>
    /// <example>
    ///   <code>private void OnTriggerEnter(Collider other)
    /// {
    ///     if (other.gameObject.CompareTag("Enemy"))
    ///     {
    ///         other.gameObject.GetComponent&lt;Enemy_Health&gt;().AddDamage(lightningDamage);
    ///     }
    /// }</code>
    /// </example>
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.GetComponent<Player_Health>().AddDamage(lightningDamage);
        }
    }

    /// <summary>Waits to destroy.</summary>
    /// <remarks>Waits 0.5 seconds before destroying the lightning bolt</remarks>
    /// <example>
    ///   <code>IEnumerator WaitToDestroy() 
    /// {
    ///     yield return new WaitForSeconds(0.5f);
    ///     Destroy(gameObject);
    /// }</code>
    /// </example>
    IEnumerator WaitToDestroy() 
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }
}
