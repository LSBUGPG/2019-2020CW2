using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>Attaches to the camera and controls its</summary>
public class Camera_Controller : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed;
    public Vector3 offset;
    public Vector3 velocity = Vector3.zero;

    /// <summary>Controls the Camera</summary>
    /// <remarks>Creates the desired position which is the target position plus the offset. Then it is smoothed and applied to the Cameras transform</remarks>
    /// <example>
    ///   <code>private void LateUpdate()
    /// {
    ///     Vector3 desiredPosition = target.position + offset;
    ///     Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothSpeed * Time.deltaTime);
    ///     transform.position = smoothedPosition;
    /// }</code>
    /// </example>
    private void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;
    }
}
