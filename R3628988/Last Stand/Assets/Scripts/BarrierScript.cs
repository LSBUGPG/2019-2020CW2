using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierScript : MonoBehaviour {

	static float startingHealth = 100f;
	public float currentHealth;
	bool isSinking;                            
	public float sinkSpeed = 2.5f;             

	// Use this for initialization
	void Awake () {
		currentHealth = startingHealth;
	}
		
	// Update is called once per frame
	void Update () {
		if(currentHealth <= 0 && transform.position.y > -5)
		{
			transform.Translate (-Vector3.up * sinkSpeed * Time.deltaTime);
		}
	}

	public float getHealth(){
		return currentHealth;
	}

	public void setHealth(float num){
		currentHealth -= num;
	}
}
