using UnityEngine;

public class CameraController : MonoBehaviour
{



    public float speedH = 2.0f;
    public float speedV = 2.0f;
    private float upMove = 0.0f;
    private float sideMove = 0.0f;

    // Start is called before the first frame update
    void Start()
    {

        Cursor.lockState = CursorLockMode.Locked;

    }

    // Update is called once per frame
    void Update()
    {



        sideMove += speedH * Input.GetAxis("Mouse X");
        upMove -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(upMove, sideMove, 0.0f);
       
    }
}