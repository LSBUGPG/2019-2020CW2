using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LootManager : MonoBehaviour
{

	public GameObject[] buildings;
	public Text xNum;
	public Text yNum;
	public Text zNum;

	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
	}

	public float itemLikelihoodHouse ()
	{
		return Random.Range (0f, 1f);
	}

	public float getAverage (int k){
		float tot = 0;
		foreach (GameObject i in buildings) {
			if (i.GetComponent<HouseScript> ().getIsActive ()) {
				float[] tempArray = i.GetComponent<HouseScript> ().getChance ();
				tot += tempArray [k];
			}
		}
		return tot / buildings.Length;
	}

	int aMethod(int m){
		if (Random.value <= getAverage (m)) {
			return 1;
		}
		return 0;
	}

	public void populateText(){
		xNum.text = "" + aMethod(0);
		yNum.text = "" + aMethod(1);
		zNum.text = "" + aMethod(2);
	}

	public void getActive ()
	{
		foreach (GameObject i in buildings) {
			if (i.GetComponent<HouseScript> ().getIsActive ()) {
				print (i + " is active");
				float[] tempArray = i.GetComponent<HouseScript> ().getChance ();
				for (int n = 0; n <= tempArray.Length - 1; n++) {
					print ("Chance is: " + tempArray [n]);
				}
			}
		}
	}
}
