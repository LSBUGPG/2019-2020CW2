using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraCollider : MonoBehaviour {

	GameObject camCont;
	bool leftSide = true;

	// Use this for initialization
	void Awake () {
		camCont = transform.parent.gameObject;
		if (this.name == "rightCollider") {
			leftSide = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider other){
		if (other.gameObject.tag == "Player") {
			camCont.gameObject.GetComponent<cameraController>().switchCamera (leftSide);
		}
	}
}
