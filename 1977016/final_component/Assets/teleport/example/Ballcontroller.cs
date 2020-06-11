using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballcontroller : MonoBehaviour {
 public float ballspeed;
	
	// Update is called once per frame
	void Update () {
		float xspeed = Input.GetAxis("Horizontal");
		float yspeed = Input.GetAxis("Vertical");
		
		Rigidbody body = GetComponent<Rigidbody> ();
		body.AddTorque(new Vector3(xspeed, 0, yspeed));
	}
}
