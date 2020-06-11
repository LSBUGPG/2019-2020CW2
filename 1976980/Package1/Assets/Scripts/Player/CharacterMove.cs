using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
	public float speed;                //Floating point variable to store the player's movement speed.

	private Rigidbody2D rb2d;

	// Start is called before the first frame update
	void Start()
	{
		//Get and store a reference to the Rigidbody2D component so that we can access it.
		rb2d = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		HorizontalMovement();
	}

	void HorizontalMovement()
	{
		//Store the current horizontal input in the float moveHorizontal.
		float moveHorizontal = Input.GetAxis("Horizontal");

		//Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
		rb2d.velocity = new Vector2(moveHorizontal * speed, rb2d.velocity.y);
	}
}