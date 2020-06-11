using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCameraWithOffset : MonoBehaviour
{
    public float OffSetX;
    public float OffSetY;
    public float speed;
    public GameObject player;

    void Start()
    {
        
    }

    void Update()
    {
        float interpolation = speed * Time.deltaTime;
        Vector3 position = this.transform.position;
        position.y = Mathf.Lerp(this.transform.position.y, player.transform.position.y + OffSetY, interpolation);
        position.x = Mathf.Lerp(this.transform.position.x, player.transform.position.x + OffSetX, interpolation);
        this.transform.position = position;
    }
}
