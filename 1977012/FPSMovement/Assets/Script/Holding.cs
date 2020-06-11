using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holding : MonoBehaviour
{
    public float distanceToPickup = 1f;
    GameObject objectInHand;
    public Vector3 Offset = new Vector3(0, 1.75f, 5);
    public Vector3 Rotation = new Vector3(0, -90, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //If the player has an object in their hand
        if(objectInHand != null)
        {
            //Put object infront of player
            /*objectInHand.transform.parent = GameObject.Find("Player").transform;
            objectInHand.transform.localPosition = Offset;
            objectInHand.transform.eulerAngles = Rotation;

            //Disable rididbody
            objectInHand.GetComponent<Rigidbody>().isKinematic = true;*/

            //If e is pressed then drop the item
            if (Input.GetKeyUp("e"))
            {
                objectInHand.transform.parent = null;
                objectInHand.GetComponent<Rigidbody>().isKinematic = false;
                objectInHand.transform.localScale = Vector3.one;

                objectInHand = null;
            }
        }
        else
        {
            //Fire a ray to see if the player is looking at an object
            RaycastHit hit;
            int mask = LayerMask.GetMask("Default");

            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, distanceToPickup, mask))
            {
                //If the collider hit an object with the tag Check
                if (hit.collider.tag == "Collect")
                {
                    //If e is pressed then pick up the object
                    if (Input.GetKeyUp("e"))
                    {
                        objectInHand = hit.collider.gameObject;
                        objectInHand.transform.parent = GameObject.Find("Player").transform;
            objectInHand.transform.localPosition = Offset;
            objectInHand.transform.eulerAngles = Rotation;

            //Disable rididbody
            objectInHand.GetComponent<Rigidbody>().isKinematic = true;
                    }
                }
            }
        }


    }
}

 
