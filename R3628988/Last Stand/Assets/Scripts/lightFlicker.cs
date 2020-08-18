using UnityEngine;
using System.Collections;

public class lightFlicker : MonoBehaviour
{
	Light _light;
	Color originalColor;
	float timePassed;
	float changeValue;
	float intensity;
	public int speed;

	void Start(){
		_light = GetComponent<Light> ();

		if (_light != null) {
			originalColor = _light.color;
		} else {
			enabled = false;
			return;
		}

		intensity = _light.intensity;
		changeValue = 0;
		timePassed = 0;
		speed = 8;
	}

	void Update(){
		timePassed = Time.time;
		timePassed = timePassed - Mathf.Floor (timePassed);

		_light.color = originalColor * CalculateChange ();
		_light.intensity = intensity * CalculateChange ();
	}

	float CalculateChange(){
		changeValue = -Mathf.Sin (timePassed * speed * Mathf.PI) * 0.05f + 0.95f;
		return changeValue;
	}
}