using System.Collections;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class EnemyManager : MonoBehaviour
{
//	public PlayerHealth playerHealth;
	public GameObject enemy;
	//public float spawnTime = 3f;
	float minSpawn = 0f;
	float maxSpawn = 2f;
	public int numToSpawn = 30;
	public Transform[] spawnPoints;
	public Transform[] destinations;
	bool canSpawn = true;

	int numOfEnemiesSpawned = 0; //total number of spawned enemies

	void Start ()
	{
		//Invoke ("Spawn", (Random.Range(minSpawn, maxSpawn)));
		
	}

	public Transform GetDestination(){
		return destinations [Random.Range (0, destinations.Length)];
	}

	public void SpawnOneMore(){
		numToSpawn++;
		print ("Num to spawn was " + (numToSpawn-1) + ", is now " + numToSpawn);
	}

//	void Spawn()
//	{
////		if(playerHealth.currentHealth <= 0f)
////		{
////			return;
////		}
//		if (numOfEnemiesSpawned <= numToSpawn-1) {
//			float delay = Random.Range (minSpawn, maxSpawn);
//			Invoke ("Spawn", delay);

//			int spawnPointIndex = Random.Range (0, spawnPoints.Length);

//			Instantiate (enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
//			numOfEnemiesSpawned++;
//			//if (numOfEnemiesSpawned % 5 == 0){
//			//	print (numOfEnemiesSpawned);
//			//}
//		}

//	}


	void Update()
    {
		if(numOfEnemiesSpawned < numToSpawn && canSpawn)
        {
			StartCoroutine(Spawn());
		}
    }

	IEnumerator Spawn()
	{
		canSpawn = false;

		yield return new WaitForSeconds(Random.Range(minSpawn, maxSpawn));

		numOfEnemiesSpawned++;

		canSpawn = true;

		int spawnPointIndex = Random.Range(0, spawnPoints.Length);

		Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
		
			//if (numOfEnemiesSpawned % 5 == 0){
			//	print (numOfEnemiesSpawned);
			//}

	}
}
