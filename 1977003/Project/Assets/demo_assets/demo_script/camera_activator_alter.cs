using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_activator_alter : MonoBehaviour
{
    public Camera camera_a;
    public Camera camera_b;
    
    [SerializeField]  
    private bool camActivate = false;

    void Start()
    {
        
        camera_a.GetComponent<wormhole_targetpoint>().enabled = false;
		camera_b.GetComponent<wormhole_targetpoint>().enabled = true;
    }

    void Update()
    {     	
		if(camActivate == false){

		camera_a.GetComponent<wormhole_targetpoint>().enabled = false;
		camera_b.GetComponent<wormhole_targetpoint>().enabled = true;
		}
		
		else if (camActivate == true){
		camera_a.GetComponent<wormhole_targetpoint>().enabled = true;
		camera_b.GetComponent<wormhole_targetpoint>().enabled = false;
		}
			
    }

    void OnTriggerEnter (Collider other){
    
        
        Debug.Log("Camera switch!");
        if(other.tag == "pl_tp_collider"){
            
            camActivate = !camActivate;
        }
    }
}