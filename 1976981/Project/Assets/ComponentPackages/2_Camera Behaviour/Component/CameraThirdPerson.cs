using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraThirdPerson : MonoBehaviour
{
    public GameObject objectToFollow;
    public float speed = 2.0f;

    public Transform lookAt;
    public Transform camTransform;

    private Camera cam;

    private float distance = 5.0f;
    private float currentX = 0.0f;
    private float currentY = 0.0f;
    private float sensitivityX = 4.0f;
    private float sensitivityY = 4.0f;
	public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
		Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        camTransform = transform;
        cam = Camera.main;
    }

    void Update()
        {
        currentX = Input.GetAxis("Mouse X");
        currentY += Input.GetAxis("Mouse Y");

        float interpolation = speed * Time.deltaTime;

       // Vector3 position = this.transform.position;
        //position.y = Mathf.Lerp(this.transform.position.y, objectToFollow.transform.position.y, interpolation);
       // position.x = Mathf.Lerp(this.transform.position.x, objectToFollow.transform.position.x, interpolation);
       // this.transform.position = position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
		objectToFollow.transform.Rotate(0, currentX*speed, 0, Space.Self);
        Vector3 dir = new Vector3(0,0, -distance);
		camTransform.position = objectToFollow.transform.position;
		camTransform.rotation = objectToFollow.transform.rotation;
        Quaternion rotation = Quaternion.Euler(currentY, 0, 0);
		camTransform.rotation *= rotation;
		camTransform.Translate(Vector3.back * distance + offset, Space.Self);
        //camTransform.position = lookAt.position + rotation * dir;
        //camTransform.LookAt (lookAt.position);
    }
}
