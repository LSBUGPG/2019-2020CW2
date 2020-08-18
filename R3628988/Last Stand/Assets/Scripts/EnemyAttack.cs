using UnityEngine;
using System.Collections;


public class EnemyAttack : MonoBehaviour
{
	public float timeBetweenAttacks = 2f;     // The time in seconds between each attack.
	public int attackDamage = 2;               // The amount of health taken away per attack.


	//Animator anim;                              // Reference to the animator component.
	GameObject player;                          // Reference to the player GameObject.
	GameObject barrier;
	BarrierScript barrierScript;
	PlayerHealth playerHealth;                  // Reference to the player's health.
	EnemyHealth enemyHealth;                    // Reference to this enemy's health.
	bool playerInRange;                         // Whether player is within the trigger collider and can be attacked.
	bool barrierInRange;
	float timer;                                // Timer for counting up to the next attack.

	void Awake ()
	{
		// Setting up the references.
		player = GameObject.FindGameObjectWithTag ("Player");
		playerHealth = player.GetComponent <PlayerHealth> ();
		enemyHealth = GetComponent<EnemyHealth>();
		//anim = GetComponent <Animator> ();
		barrier = GameObject.FindGameObjectWithTag("Barrier");
		barrierScript = barrier.GetComponent<BarrierScript> ();


	}


	void OnTriggerEnter (Collider other)
	{
		// If the entering collider is the player...
		if (other.gameObject.tag == "Player") {
			playerInRange = true;
		} else if (other.gameObject.tag == "Barrier") {
			barrierInRange = true;
		}
	}


	void OnTriggerExit (Collider other)
	{
		// If the exiting collider is the player...
		if (other.gameObject.tag == "Player") {
			playerInRange = false;
		} 
		if (other.gameObject.tag == "Barrier") {
			barrierInRange = false;
		}

	}


	void Update ()
	{
		// Add the time since Update was last called to the timer.
		timer += Time.deltaTime;

		// If the timer exceeds the time between attacks, the player is in range and this enemy is alive...
		if(timer >= timeBetweenAttacks && playerInRange && enemyHealth.currentHealth > 0)
		{
			// ... attack.
			print("Player is in range!");
			AttackPlayer ();
		}

		if(timer >= timeBetweenAttacks && barrierInRange && barrierScript.getHealth() > 0)
				{
					// ... attack.
					AttackBarrier ();
				}

		// If the player has zero or less health...
//		if(playerHealth.currentHealth <= 0)
//		{
//			// ... tell the animator the player is dead.
//			anim.SetTrigger ("PlayerDead");
//		}
	}


	void AttackPlayer ()
	{
		// Reset the timer.
		timer = 0f;

		 //If the player has health to lose...
		if(playerHealth.currentHealth > 0)
		{
			// ... damage the player.
			playerHealth.TakeDamage (attackDamage);
		}
	}

	void AttackBarrier(){
		// Reset the timer.
		timer = 0f;
		if(barrierScript.getHealth() > 0)
		{
			barrierScript.setHealth(attackDamage);
			//print ("attacking for " + attackDamage + " damage!");
		}
	}
}