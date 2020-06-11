using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
	public GameObject Player;
	public GameObject bulletPrefab;
	public float force = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
		{
			RaycastHit hit;
            Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward,out hit);
			GameObject bullet = Instantiate(bulletPrefab, Player.transform.position, Quaternion.identity);
			Rigidbody rb = bullet.GetComponent<Rigidbody>();
			rb.AddForce((hit.point - Player.transform.position).normalized * force, ForceMode.Impulse);
			Destroy(bullet, 15f);
		}
    }
}