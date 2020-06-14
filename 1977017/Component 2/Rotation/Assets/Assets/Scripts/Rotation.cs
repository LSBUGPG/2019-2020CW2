using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    float rotationSpeed = 1f;


    private void OnMouseDrag()
    {
        //float XAxistRoatation = Input.GetAxis("Mouse X") * rotationSpeed;
        //transform.Rotate(Vector3.down, XAxistRoatation);
        float YAxistRoatation = Input.GetAxis("Mouse Y") * rotationSpeed;
        transform.Rotate(Vector3.forward, YAxistRoatation);
    }
}
