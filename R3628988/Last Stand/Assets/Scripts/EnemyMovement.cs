using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
	PlayerHealth playerHealth;
	EnemyHealth enemyHealth;
	UnityEngine.AI.NavMeshAgent nav;
	GameObject player;                          
	GameObject barrier; 
	BarrierScript barrierScript;
	bool playerInRange;                       
	GameObject eManager;
	EnemyManager enemyManager;
	Transform destination;

	void Start(){
		barrier = GameObject.FindGameObjectWithTag("Barrier");
		barrierScript = barrier.GetComponent<BarrierScript> ();

		eManager = GameObject.Find("EnemyManager");
		enemyManager = eManager.GetComponent<EnemyManager> ();

		destination = enemyManager.GetDestination ();
	}


	void Awake ()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		playerHealth = player.GetComponent <PlayerHealth> ();
		enemyHealth = GetComponent <EnemyHealth> ();
		nav = GetComponent <UnityEngine.AI.NavMeshAgent> ();
	}

	void OnTriggerEnter (Collider other)
	{
		// If the entering collider is the player...
		if(other.gameObject == player)
		{
			// ... the player is in range.
			playerInRange = true;
		}
	}

	void Update ()
	{
		if (barrierScript.getHealth() > 0 && enemyHealth.currentHealth > 0) {
			nav.SetDestination (destination.position);
		} else if (barrierScript.getHealth() <= 0 && enemyHealth.currentHealth > 0){
			nav.SetDestination (player.transform.position);
		}
	}
}