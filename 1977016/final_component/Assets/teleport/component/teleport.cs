using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour {
public Transform teleportdestination;
	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			other.transform.position = teleportdestination.position;
		}
	}
}
