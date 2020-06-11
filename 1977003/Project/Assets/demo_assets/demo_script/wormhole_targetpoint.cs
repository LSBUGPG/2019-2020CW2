using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wormhole_targetpoint : MonoBehaviour
{
    public GameObject targetpoint_Prefab;
    public float objDistance = 0;

    public bool endpointActive = false;

    void Update()
    {
    
        if(endpointActive == false){

            if(Input.GetMouseButtonDown(0)){
                GameObject myendpointPrefab = Instantiate(targetpoint_Prefab, transform.position + (transform.forward * objDistance), transform.rotation) as GameObject;
                endpointActive = true;
                Debug.Log("Wormhole Endpoint Activate!");
            }   
        }

        if(endpointActive == true){

            if(Input.GetMouseButtonDown(1)){

                    endpointActive = false;

            }   
        }  
    }
}
