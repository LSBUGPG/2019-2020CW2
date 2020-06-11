using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>Controls the Player shooting and Looking</summary>
public class Player_Shooting : MonoBehaviour
{
    public int bulletForce;
    public int bulletDmg;
    public float rotationSpeed;
    public Transform firePoint;
    public GameObject bullet;

    /// <summary>Sets the Bullet layer and Player Layer to ignore eachother. Prevents bullets getting stuck in player when fired</summary>
    /// <example>
    ///   <code>void Start()
    /// {
    ///     Physics.IgnoreLayerCollision(9, 12);
    /// }</code>
    /// </example>
    void Start()
    {
        Physics.IgnoreLayerCollision(9, 12);
    }

    /// <summary>Calls ControlMouse function. Checks if fire button pressed</summary>
    /// <example>
    ///   <code>void Update()
    /// {
    ///     ControlMouse();
    ///
    ///     if (Input.GetMouseButtonDown(0))
    ///     {
    ///         FireBullet();
    ///     }
    /// }</code>
    /// </example>
    void Update()
    {
        ControlMouse();

        if (Input.GetMouseButtonDown(0))
        {
            FireBullet();
        }
    }

    Vector3 lookPos;
    /// <summary>Controls the mouse.</summary>
    /// <remarks>Creates a raycast down that sets the lookPos to wherever it hits. The Player looks to wherever the ray hits</remarks>
    /// <example>
    ///   <code>Vector3 lookPos;
    /// void ControlMouse() 
    /// {
    ///     RaycastHit hit;
    ///     Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    ///
    ///     if (Physics.Raycast(ray, out hit, 50))
    ///     {
    ///         lookPos = hit.point;
    ///     }
    ///
    ///     Vector3 lookDir = lookPos - transform.position;
    ///     lookDir.y = 0;
    ///
    ///     transform.LookAt(transform.position + lookDir);
    /// }</code>
    /// </example>
    void ControlMouse() 
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 50))
        {
            lookPos = hit.point;
        }

        Vector3 lookDir = lookPos - transform.position;
        lookDir.y = 0;

        transform.LookAt(transform.position + lookDir);
    }

    /// <summary>Fires a bullet.</summary>
    /// <remarks>Instantiates a bullet as a gameObject and gets its rigidBody. Adds an impulse force to the bullet which is the bulletForce</remarks>
    /// <example>
    ///   <code>void FireBullet() 
    /// {
    ///     GameObject instBullet = Instantiate(bullet, firePoint.position, firePoint.rotation) as GameObject;
    ///     Rigidbody rb = instBullet.GetComponent&lt;Rigidbody&gt;();
    ///     rb.AddForce(transform.forward * bulletForce, ForceMode.Impulse);
    /// }</code>
    /// </example>
    void FireBullet() 
    {
        GameObject instBullet = Instantiate(bullet, firePoint.position, firePoint.rotation) as GameObject;
        Rigidbody rb = instBullet.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * bulletForce, ForceMode.Impulse);
    }
}
