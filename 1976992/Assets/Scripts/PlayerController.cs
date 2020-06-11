using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public TextMeshProUGUI countText;

    public GameObject ground;
    public CameraController camScript;

    public GameObject distanceMarker;
    public GameObject player;
    public float distance;
    bool startDistanceCount;

    private Rigidbody rb;
    private int count;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        setCountText ();
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");
        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
        rb.AddForce (movement * speed);

        distance = Vector3.Distance(player.transform.position, distanceMarker.transform.position);


        if(startDistanceCount)
            setCountText ();

        if (count >=6)
        {
            ground.SetActive(false);
            camScript.CameraAnimation();        
        }


        if (Input.GetKey("escape"))
        {
            //Debug.Log("patata");
            Application.Quit();
        }
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag ("Pick Up"))
        {
            other.gameObject.SetActive (false);
            count = count + 1;
            
        }

        if(other.tag == "StartCount")
            startDistanceCount = !startDistanceCount;
    }

    void setCountText ()
    {
        countText.text = "Distance: " + distance.ToString ("F0");

    }

}