using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunMovement : MonoBehaviour {

	float rotationZ;
	public float verticalAimRange = 90f;
	void Start()
	{
		transform.rotation = Quaternion.identity;
		Cursor.lockState = CursorLockMode.Locked;
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
        {
			Cursor.lockState = CursorLockMode.None;
		}
		//Debug.Log(transform.rotation.eulerAngles.z);
		LockedRotation();
	}

	void LockedRotation()
	{
		//Screen.lockCursor = true;
		rotationZ += -Input.GetAxis("Mouse Y");
		rotationZ = Mathf.Clamp(rotationZ, -verticalAimRange, verticalAimRange);
		transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, -rotationZ);
	}
}
