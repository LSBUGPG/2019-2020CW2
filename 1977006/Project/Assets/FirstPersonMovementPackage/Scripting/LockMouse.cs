using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockMouse : MonoBehaviour
{

    void Update()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;
    }
}