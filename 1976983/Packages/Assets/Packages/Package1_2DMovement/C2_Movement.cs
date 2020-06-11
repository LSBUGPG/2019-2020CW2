using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C2_Movement : MonoBehaviour
{

    public C1_2DController controller;
    public float speed = 40f;
    float LRmove = 0f;
    bool jump = false;

    void Update()
    {
        LRmove = Input.GetAxisRaw("Horizontal") * speed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    private void FixedUpdate()
    {
        controller.Move(LRmove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}