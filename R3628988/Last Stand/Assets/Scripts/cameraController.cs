using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour {
	public Camera camR;
	public Camera camL;

	// Use this for initialization
	void Awake () {
		camL.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void switchCamera(bool leftSide){

		if (leftSide) {
			camR.enabled = true;
			camL.enabled = false;
		} else {
			camR.enabled = false;
			camL.enabled = true;
		}
	}
}
