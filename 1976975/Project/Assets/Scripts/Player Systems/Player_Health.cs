using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

/// <summary>Applied to Player.  Controls health and death. Player HP can be set</summary>
public class Player_Health : MonoBehaviour
{
    public float playerHP;
    public TextMeshProUGUI playerHealthDisplay;

    /// <summary>References text</summary>
    /// <example>
    ///   <code>private void Start()
    /// { 
    ///     playerHealthDisplay.text = string.Format("Health: {0}", playerHP.ToString("F0"));
    /// }</code>
    /// </example>
    private void Start()
    { 
        playerHealthDisplay.text = string.Format("Health: {0}", playerHP.ToString("F0"));
    }

    float dmgTaken;
    /// <summary>Adds the damage.</summary>
    /// <param name="dmgAmount">The DMG amount.</param>
    /// <remarks>Can be called by other scripts such as enemies. A value can be passed through which is the amount of damage that you want to apply</remarks>
    /// <example>
    ///   <code>float dmgTaken;
    /// public void AddDamage(float dmgAmount) 
    /// {
    ///     dmgTaken += dmgAmount;
    ///     float currentHealth = playerHP - dmgTaken;
    ///     playerHealthDisplay.text = string.Format("Health: {0}", currentHealth.ToString("F0"));
    ///
    ///     if (dmgTaken &gt;= playerHP)
    ///     {
    ///         Destroy(gameObject);
    ///         SceneManager.LoadScene(0);
    ///     }
    /// }</code>
    /// </example>
    public void AddDamage(float dmgAmount) 
    {
        dmgTaken += dmgAmount;
        float currentHealth = playerHP - dmgTaken;
        playerHealthDisplay.text = string.Format("Health: {0}", currentHealth.ToString("F0"));

        if (dmgTaken >= playerHP)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(0);
        }
    }
}
