using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class y_axis : MonoBehaviour
{
    [SerializeField]
    private float _sensibility = 1f;
    private float _mouseY;

    void Update()
    {
        _mouseY -= Input.GetAxis("Mouse Y") * _sensibility * Time.deltaTime;
        _mouseY = Mathf.Clamp (_mouseY, -90, 90);

        transform.localEulerAngles = new Vector3 (_mouseY, transform.localEulerAngles.y, transform.localEulerAngles.z);
    }
}
