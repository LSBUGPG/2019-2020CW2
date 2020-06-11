using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch : MonoBehaviour
{
    CharacterController characterCollider; 
    void Start()
    {
        characterCollider = gameObject.GetComponent<CharacterController>();
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.C))
        {
            characterCollider.height = 1.8f; 
        }
        else
        {
            characterCollider.height = 3.8f; 
        }
    }
}
