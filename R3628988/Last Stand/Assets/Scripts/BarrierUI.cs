using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarrierUI : MonoBehaviour {

	Slider slider;

	public GameObject barrier;
	BarrierScript barrierScript;

	void Awake () {
		slider = GetComponent<Slider> ();
		barrierScript = barrier.GetComponent<BarrierScript> ();
	}

	void Update(){
		slider.value = barrierScript.getHealth()/100;
	}
}
