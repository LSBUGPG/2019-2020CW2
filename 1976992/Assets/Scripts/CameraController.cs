using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    public Animator anim;

    public Vector3 offset;

    public float lookAhead = 1.0f;

    void Start ()
    {
        offset = transform.position - player.transform.position;
        anim.enabled = false;
    }

    void LateUpdate ()
    {
        transform.position = player.transform.position + offset;
        transform.LookAt(player.transform.position + Vector3.forward * lookAhead);
    }

    public void CameraAnimation()
    {
        anim.enabled = true;
        anim.Play("CameraAnimation");
        lookAhead = 2.5f;
    }
}
