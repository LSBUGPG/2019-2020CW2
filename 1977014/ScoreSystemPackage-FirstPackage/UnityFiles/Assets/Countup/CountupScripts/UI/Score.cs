using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	public Text ScoreText;
	// What we are referencing
	public int IncrementAmount = 1;
	[Tooltip("Value in Miliseconds")]
	public float ScoreSpeed = 1000f;

	// Added Varibels that can be changed publicly 

	int TheScore = 0;

	// Use this for initialization
	void Start () {
		//ScoreText.text="Score: " + TheScore;
		// Test Function for scoring system	
		IncreaseScore(1000);

	}

	public void IncreaseScore (int amount){
		StartCoroutine ("CountUp", amount);


	}

	IEnumerator CountUp(int amount) {
		for (int i = 0; i < amount; i+=IncrementAmount)
		{
			yield return new WaitForSeconds(ScoreSpeed/1000f);
				ScoreText.text="Score: " +(TheScore + (i + IncrementAmount)).ToString("0");
		}
	
	}
}
