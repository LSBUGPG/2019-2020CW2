using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPOV : MonoBehaviour
{

    public Transform player;

    public Camera firstPersonCam, thirdPersonCam;

    public KeyCode cKey;

    public bool camSwitch = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(cKey))
        {
            camSwitch = !camSwitch;
            firstPersonCam.gameObject.SetActive(camSwitch);
            thirdPersonCam.gameObject.SetActive(!camSwitch);
        }
    }
}
