using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerLook : MonoBehaviour
{

    [SerializeField] private string mouseXInputName = "", mouseYInputName = "";
    [SerializeField] private float mouseSensitivity = 0;

    [SerializeField] private Transform playerBody = null;

    private float xAxisClamp;

    private void Awake()
    {
        LockCursor();
        xAxisClamp = 0.0f;
    }

    public void LockCursor()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        CameraRotation();
    }

    private void CameraRotation()
    {
        float mouseX = Input.GetAxis(mouseXInputName) * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis(mouseYInputName) * mouseSensitivity * Time.deltaTime;

        xAxisClamp += mouseY;

        if (xAxisClamp > 90.0f)
        {
            xAxisClamp = 90f;
            mouseY = 0;
            ClampXAxisRotationToValue(270);
        }
        else if (xAxisClamp < -90.0f)
        {
            xAxisClamp = -90f;
            mouseY = 0;
            ClampXAxisRotationToValue(90);
        }

        transform.Rotate(Vector3.left * mouseY);
        playerBody.Rotate(Vector3.up * mouseX);

    }

    private void ClampXAxisRotationToValue(float value)
    {
        Vector3 eulerRotation = transform.eulerAngles;
        eulerRotation.x = value;
        transform.eulerAngles = eulerRotation;
    }
}
