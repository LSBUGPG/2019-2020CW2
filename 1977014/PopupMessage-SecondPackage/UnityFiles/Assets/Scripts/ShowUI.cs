﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowUI : MonoBehaviour {

	public GameObject uiObject;

	// Use this for initialization
	void Start () 
	{
		uiObject.SetActive (false);
	}

	void OnTriggerEnter (Collider Player)
	{
		if (Player.gameObject.tag == "Player") 
		{
			uiObject.SetActive (true);
			StartCoroutine ("WaitForSec");
		}
	}
	IEnumerator WaitForSec()
	{
		yield return new WaitForSeconds (5);
		Destroy (uiObject);
		Destroy (gameObject);
	}
}