using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public Controller controller;
    void Update()
    {
        if (Input.anyKeyDown)
        {
            controller.GivenInput();
        }
    }
}
