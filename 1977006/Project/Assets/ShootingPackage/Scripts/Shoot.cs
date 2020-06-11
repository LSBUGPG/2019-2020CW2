﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public Camera playerCamera;
    public GameObject bulletPrefab;
    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Fire");
            GameObject bulletObject = Instantiate(bulletPrefab);
            bulletObject.transform.position = playerCamera.transform.position + playerCamera.transform.forward;
            bulletObject.transform.forward = playerCamera.transform.forward;
        }
    }

    
}