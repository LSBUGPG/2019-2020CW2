using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public Animator anim;
    public GameObject keyequip;
    public GameObject playercomp;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void OnTriggerStay(Collider other)


    {
        if (other.gameObject.tag == "Player")
        {

            foreach (Transform child in playercomp.transform)
            {


                if ((child.tag == "Key") & (Input.GetKeyDown("e")))
                {
                    anim.SetBool("SwingOpen", true);
                }
                    


            }
        }
    }


   
}
