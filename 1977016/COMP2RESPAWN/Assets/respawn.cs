using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
 {
 [SerializeField] private Transform player;
 [SerializeField] private Transform respawnpoint;
 
	// Use this for initialization
	void OnTriggerEnter(Collider other) 
	{
		player.transform.position = respawnpoint.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
