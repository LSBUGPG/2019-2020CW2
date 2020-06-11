using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowUI : MonoBehaviour {

	public GameObject uiObject;

	public float GrowthSpeed=0.01f;

	RectTransform RT;

	bool canGrow = false;

	// Use this for initialization
	void Start () 
	{
		RT = GetComponent<RectTransform>();
		RT.localScale = new Vector3(0.3f, 0.3f, 0.3f);
		uiObject.SetActive (false);
		Invoke("StartGrowth", 1f);
	}

	void StartGrowth() 
	{
		uiObject.SetActive(true);
		canGrow = true;
	}
	private void Update()
	{
		if (RT.localScale.x<1f && canGrow)
		{
			RT.localScale += new Vector3(GrowthSpeed, GrowthSpeed, GrowthSpeed);
		}

	}


}