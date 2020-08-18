using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class SetTagOnAwake : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.gameObject.tag = "Key";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
