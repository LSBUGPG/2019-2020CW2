using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>Health System</summary>
/// <remarks>
/// A reusable enemy health system that retrieves the rolled Index number from the AI_Spawner Class to then retrieve the corresponding health value. Apply this script to an enemy prefab and set the health value in AI_Spawner
/// </remarks>
public class Enemy_Health : MonoBehaviour
{
    private float aiHP;
    private AI_Controller aiController;
    private int healthIndex;
    private int pointsPerKill;

    /// <summary>Initialise</summary>
    /// <remarks>References the AI_Spawner, sets the healthIndex to the enemyIndex, then sets the aiHP to the corrsesponding health value in the enemyTypes list</remarks>
    /// <example>
    ///   <code>private void Start()
    /// {
    ///     aiController = GameObject.Find("AI Controller").GetComponent&lt;AI_Controller&gt;();
    ///     healthIndex = GameObject.Find("AI Controller").GetComponent&lt;AI_Controller&gt;().enemyIndex;
    ///     aiHP = GameObject.Find("AI Controller").GetComponent&lt;AI_Controller&gt;().enemyTypes[0].health;
    /// }</code>
    /// </example>
    private void Start()
    {
        aiController = GameObject.Find("AI Controller").GetComponent<AI_Controller>();
        pointsPerKill = GameObject.Find("Game Controller").GetComponent<Game_Controller>().pointsPerKill;
        healthIndex = GameObject.Find("AI Controller").GetComponent<AI_Controller>().enemyIndex;
        aiHP = GameObject.Find("AI Controller").GetComponent<AI_Controller>().enemyTypes[healthIndex].health;
    }


    float dmgTaken;
    /// <summary>Adds a damage value to the enemy.</summary>
    /// <param name="dmgAmount">The amount of damage to apply</param>
    /// <remarks>
    /// When this method is called you pass through the amount of damge you want to apply. If the total dmgTaken is greater than the assigned HP value then the enemy dies and is removed from the list and another enemy is rollled and spawned
    /// </remarks>
    /// <example>
    ///   <code>public void AddDamage(float dmgAmount)
    /// {
    ///     dmgTaken += dmgAmount;
    ///     if (dmgTaken &gt;= aiHP)
    ///     {
    ///         aiController.RemoveFromList(gameObject);
    ///         aiController.EnemyIndexRoll();
    ///         Destroy(gameObject);
    ///     }
    /// }</code>
    /// </example>
    public void AddDamage(float dmgAmount)
    {
        dmgTaken += dmgAmount;
        if (dmgTaken >= aiHP)
        {
            aiController.RemoveFromList(gameObject);
            aiController.EnemyIndexRoll();
            GameObject.Find("Game Controller").GetComponent<Game_Controller>().AddPoints(pointsPerKill);
            Destroy(gameObject);
        }
    }
}
