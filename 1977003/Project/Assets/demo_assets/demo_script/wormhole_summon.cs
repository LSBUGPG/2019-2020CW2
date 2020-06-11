using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wormhole_summon : MonoBehaviour
{
    public GameObject wormholePrefab;
    public GameObject wormholeprefab_Alter;

    public float objDistance = 0;

    public bool portalIsActive = false;
    
    public GameObject wormhole_alpha;
    public GameObject wormhole_alpha_alter;
    public GameObject wormhole_omega;
    public GameObject wormhole_omega_alter;

    public bool wormhole_alter = false;

    void Update()
    {

        if(portalIsActive == false){

            if(Input.GetMouseButtonDown(0)){
                
                if(wormhole_alter == false){

                    GameObject myprefab = Instantiate(wormholePrefab, transform.position + (transform.forward * objDistance), transform.rotation) as GameObject;
                    portalIsActive = true;
                    Debug.Log("Wormhole Activated!");

                }

                else if(wormhole_alter == true){

                    GameObject myprefab_alter = Instantiate(wormholeprefab_Alter, transform.position + (transform.forward * objDistance), transform.rotation) as GameObject;
                    portalIsActive = true;
                    Debug.Log("Wormhole Alter Activated!");
                }
            }
        }


        if(portalIsActive == true){


            if(wormhole_alter == false){

                wormhole_alpha = GameObject.FindWithTag("wormhole");
                wormhole_omega = GameObject.FindWithTag("endpoint");

            }
            else if( wormhole_alter == true){

                wormhole_alpha_alter = GameObject.FindWithTag("wormhole");
                wormhole_omega_alter = GameObject.FindWithTag("endpoint");

            }

            if(Input.GetMouseButtonDown(1)){

                if(wormhole_alter == false){

                    portalIsActive = false;
                    Destroy(wormhole_alpha);
                    Destroy(wormhole_omega);
                    Debug.Log("Wormhole Deactivated!");

                }

                else if(wormhole_alter == true){

                    portalIsActive = false;
                    Destroy(wormhole_alpha_alter);
                    Destroy(wormhole_omega_alter);
                    Debug.Log("Wormhole Alter Deactivated!");

                }
            }
        }
    }
}