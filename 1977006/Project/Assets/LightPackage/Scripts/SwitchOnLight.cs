﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchOnLight : MonoBehaviour
{
    public GameObject lightSwitch;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            
            Debug.Log("collision");
            lightSwitch.gameObject.SetActive(true);
        }


    }

}