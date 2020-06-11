using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>Stores the Abilities Code</summary>
/// <remarks>This class is very much a blank slate and can be filled with lots of different ability functions that can be callled from the Ability_Controller class</remarks>
public class Abilities : MonoBehaviour
{
    public GameObject lightningStrike;
    public GameObject player;


    /// <summary>Spawns a Lightning Strike</summary>
    /// <remarks>Spawns a lightning strike prefab that is raised in the air at the mouse position</remarks>
    /// <example>
    ///   <code>public void LightningStrike()
    /// {
    ///     Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    ///     mousePosition.y = 20f;
    ///     Instantiate(lightningStrike, mousePosition, Quaternion.identity);
    /// }</code>
    /// </example>
    public void LightningStrike()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.y = 20f;
        Instantiate(lightningStrike, mousePosition, Quaternion.identity);
    }

    /// <summary>Teleports Player</summary>
    /// <remarks>Teleports the player to the mouse position. The Character Controller overrides manual changes to the transform so must be disabled</remarks>
    /// <example>
    ///   <code>public void Teleport() 
    /// {
    ///     Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    ///     CharacterController cC = player.GetComponent&lt;CharacterController&gt;();
    ///     cC.enabled = false;
    ///     player.transform.position = mousePosition;
    ///     cC.enabled = true;
    /// }</code>
    /// </example>
    public void Teleport() 
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        CharacterController cC = player.GetComponent<CharacterController>();
        cC.enabled = false;
        player.transform.position = mousePosition;
        cC.enabled = true;
    }
}
