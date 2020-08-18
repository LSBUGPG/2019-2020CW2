using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var pos = GameObject.FindGameObjectWithTag("Player").transform.position;
        pos += offset;
        transform.position = Vector3.Slerp(transform.position, pos, 0.002f);
    }
}
