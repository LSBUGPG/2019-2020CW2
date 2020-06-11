using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactions : MonoBehaviour
{
	GameObject ePrefab, eInGame;
	public bool canInteract;
	bool interactionRunning;

	private void Awake()
	{
		ePrefab = Resources.Load<GameObject>("Interactions/EToInteract") as GameObject;
		print(ePrefab.name);
	}

	public void Update()
    {
		if (canInteract)
		{
			if (eInGame == null)
				eInGame = Instantiate(ePrefab, transform.position + Vector3.up, Quaternion.identity);
		}
		else
		{
			if (eInGame != null)
				Destroy(eInGame);
		}

		if (canInteract && Input.GetKeyDown(KeyCode.E) && !interactionRunning)
			RunInteraction();
    }

	public virtual void RunInteraction()
	{
		print("Baseline interaction.");
		return;
	}

	public void EndIntraction()
	{
		interactionRunning = false;
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Player"))
			canInteract = true;
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		if(collision.CompareTag("Player"))
			canInteract = false;
	}
}
