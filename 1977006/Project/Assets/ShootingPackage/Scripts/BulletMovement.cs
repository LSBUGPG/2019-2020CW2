﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float speed = 20f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()//make the bullet move
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }


    
}