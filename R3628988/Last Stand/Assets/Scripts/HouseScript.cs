using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseScript : MonoBehaviour {

	Light houseLight;
	Animator anim;
	bool isActive;
	public GameObject lootM;
	LootManager lootManager;
	float[] itemChance = new float[3];

	// Use this for initialization
	void Awake () {
		houseLight = GetComponent<Light> ();
		anim = GetComponentInChildren<Animator> ();
		lootManager = lootM.GetComponent<LootManager> ();
	}

	void Start(){
		for (int n = 0; n <= itemChance.Length-1; n++) {
			itemChance[n] = lootManager.itemLikelihoodHouse ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseOver(){
		//houseLight.enabled = true;

		if(Input.GetMouseButtonDown(0)){
			if (isActive) {
				anim.SetBool ("active", false);
				isActive = false;
			} else {
				anim.SetBool("active", true);
				isActive = true;
			}
		}
	}

	void OnMouseExit(){
		//houseLight.enabled = false;
	}

	public float[] getChance(){
		return itemChance;
	}

	public bool getIsActive(){
		return isActive;
	}
}
