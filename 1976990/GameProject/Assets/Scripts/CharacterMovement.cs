using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed = 5;

    float moveX;
    float moveY;
    // Start is called before the first frame update
    void Start()
    {
        moveX = 0;
        moveY = 0;
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
        transform.position += new Vector3(speed * moveX * Time.deltaTime, speed * moveY * Time.deltaTime, 0);
    }
}
