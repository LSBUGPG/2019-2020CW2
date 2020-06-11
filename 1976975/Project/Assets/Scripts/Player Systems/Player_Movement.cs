using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>Applied to Player. Grabs Character Controller automatically.  Controls Player movement</summary>
[RequireComponent(typeof(CharacterController))]
public class Player_Movement : MonoBehaviour
{
    public float moveSpeed;
    CharacterController controller;

    /// <summary>References Character Controller</summary>
    /// <example>
    ///   <code>void Start()
    /// {
    ///     controller = GetComponent&lt;CharacterController&gt;();
    /// }</code>
    /// </example>
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        PlayerMovement();
    }

    /// <summary>Controls player movement</summary>
    /// <remarks>
    /// Gets Vertical or Horizontal inputs. If both inputs are pressed together then their values are reduced to stop the Player speeding up diagonally. Applies motion to character controller
    /// </remarks>
    /// <example>
    ///   <code>void PlayerMovement() 
    /// {
    ///     Vector3 moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
    ///     Vector3 motion = moveInput;
    ///     motion *= (Mathf.Abs(moveInput.x) == 1 &amp;&amp; Mathf.Abs(moveInput.z) == 1) ? .7f : 1;
    ///     motion += Vector3.up * -8;
    ///     controller.Move(motion * Time.deltaTime * moveSpeed);
    /// }</code>
    /// </example>
    void PlayerMovement() 
    {
        Vector3 moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        Vector3 motion = moveInput;
        motion *= (Mathf.Abs(moveInput.x) == 1 && Mathf.Abs(moveInput.z) == 1) ? .7f : 1;
        motion += Vector3.up * -8;
        controller.Move(motion * Time.deltaTime * moveSpeed);
    }
}
