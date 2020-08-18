using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float speed = 6f;                        

	Vector3 movement;                                                            
	Rigidbody playerRigidbody;                     
	public float rotationX;
	public float horizontalAimRange = 80f;

	void Awake()
	{

		playerRigidbody = GetComponent<Rigidbody>();
		transform.rotation = Quaternion.identity;

	}

	void FixedUpdate()
	{
		float h = Input.GetAxisRaw("Horizontal");
		float v = Input.GetAxisRaw("Vertical");

		Move(h,v);                

	}

	void Update(){
//		float mouseInput = Input.GetAxis("Mouse X");
//		Vector3 lookhere = new Vector3(0,mouseInput,0);
//		transform.Rotate(lookhere);	
		LockedRotation();

	}

	void Move (float h, float v)
	{
		movement.Set(v, 0f, -h);                                             
		movement = movement.normalized * speed * Time.deltaTime;            
		playerRigidbody.MovePosition(transform.position + movement);        
	}

	void LockedRotation()
	{
		rotationX += -Input.GetAxis("Mouse X");
		rotationX = Mathf.Clamp(rotationX, -horizontalAimRange, horizontalAimRange);
		transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, -rotationX, transform.localEulerAngles.z);
	}
}