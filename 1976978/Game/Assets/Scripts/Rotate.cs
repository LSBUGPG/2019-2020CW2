﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.eulerAngles += new Vector3(0, speed, 0);
    }
}
