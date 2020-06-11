using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/// <summary>Basic enemy melee AI that uses the Unity Navmesh system for navigation</summary>
public class Melee_AI : MonoBehaviour
{
    public Transform playerTransform;
    public Player_Health playerHP;
    public int turnSpeed;
    public float attackDamage;
    public float attackSpeed;

    private NavMeshAgent navAgent;
    private Vector3 desiredRotation;


    // Start is called before the first frame update
    /// <summary>Gets Navmesh Component</summary>
    /// <example>
    ///   <code>void Start()
    /// {
    ///     navAgent = GetComponent&lt;NavMeshAgent&gt;();
    /// }</code>
    /// </example>
    void Start()
    {
        playerTransform = GameObject.Find("Player").GetComponent<Transform>();
        playerHP = GameObject.Find("Player").GetComponent<Player_Health>();
        navAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    /// <summary>Calls AI behaviours</summary>
    /// <example>
    ///   <code>void Update()
    /// {
    ///     LookAtPlayer();
    ///     MoveToPlayer();
    /// }</code>
    /// </example>
    void Update()
    {
        LookAtPlayer();
        MoveToPlayer();
    }

    /// <summary>Looks at player.</summary>
    /// <remarks>Gets the players location and takes away the enemy poition to get the desired rotation. The rotation is then normalised and rotated to.</remarks>
    /// <example>
    ///   <code>void LookAtPlayer() 
    /// {
    ///     desiredRotation = playerTransform.position - transform.position;
    ///     desiredRotation.Normalize();
    ///     transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(desiredRotation), turnSpeed * Time.deltaTime);
    /// }</code>
    /// </example>
    void LookAtPlayer() 
    {
        desiredRotation = playerTransform.position - transform.position;
        desiredRotation.Normalize();
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(desiredRotation), turnSpeed * Time.deltaTime);
    }

    /// <summary>Moves to player.</summary>
    /// <remarks>Gets the player position. Sets the navAgent destination to the player</remarks>
    /// <example>
    ///   <code>void MoveToPlayer() 
    /// {
    ///     Vector3 targetDestination = playerTransform.transform.position;
    ///     navAgent.SetDestination(targetDestination);
    /// }</code>
    /// </example>
    void MoveToPlayer() 
    {
        Vector3 targetDestination = playerTransform.transform.position;
        navAgent.SetDestination(targetDestination);
    }

    /// <summary>Attack Function</summary>
    /// <remarks>If the enemy stays in the players trigger zone then the enemy will attack the player every X amount of by X amount of damage that can be set in inspector</remarks>
    /// <example>
    ///   <code>float timer;
    /// private void OnTriggerStay(Collider col)
    /// {
    ///     timer += Time.deltaTime;
    ///     if (timer &gt;= attackSpeed)
    ///     {
    ///         playerHP.AddDamage(attackDamage);
    ///         timer = 0;
    ///     }
    /// }</code>
    /// </example>
    float timer;
    private void OnTriggerStay(Collider col)
    {
        timer += Time.deltaTime;
        if (timer >= attackSpeed)
        {
            playerHP.AddDamage(attackDamage);
            timer = 0;
        }
    }
}
