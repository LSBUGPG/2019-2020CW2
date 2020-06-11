using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfessorController : Interactions
{
	public List<string> dialogueSentences;

	void Start()
	{

	}

	void Update()
	{
		base.Update();
	}

	public override void RunInteraction()
	{
		print("We Interacting with professor now");

		//YarnSpinner.Run goes here
	}
}
