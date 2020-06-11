SWITCHING BETWEEN TWO CAMERAS

1.) Create two cameras

    On new unity project or existing one, create two camera on the scene.
    Right click on the "Hierarchy" tab and click Camera.
    Rename the two cameras. (Example: "camera_a", "camera_b")
    
2.) Setting up the script for the camera switch
    
    Create an empty gameobject by right clicking on the "Hierachy" tab then click "Create Empty".
    Rename the empty game object on the "Inspector" to any name of your liking. (Example: "camera switch manager")
    On the "Inspector" while hovering on your "camera switch manager", click add component then new script.
    Name the new script whatever you like. (Example: "camera_switch")

3.) Creating a script for camera switch

    Open your "camera_switch" script.
    Public class, void start and void update is automatically added there whenever you creating new script using unity.
    Under the public class, type:

        [SerializeField]
        Camera camera_a
        
        [SerializeField]
        Camera camera_b

        public bool cameraSwtich = false;

        Note: The [SerializeField] make it possible for the to see the camera slot on the "Inspector".
              This way you can just drag both camera on their respective slot.
              The Camera on the "Camera camera_a or camera_b" is there for unity engine to recognise that you are working with camera components.
              public bool cameraSwitch = false; will be the lever mechanism for our code later.

    Under the void Start, type:

        camera_a.GetComponent<Camera>().enabled = true;
        camera_b.GetCompoennt<Camera>().enabled = false;

        Note: This code line let the camera you want on the play while disabling the other one.
              The line above is interchangable on whatever camera you want active on play.
              Code line above will start with camera_a active and camera_b inactive.
              GetComponent<Camera>() on the line lets the unity engine know that you are selecting the "Camera" component on the "Inspector".

    Under the void Update, type:

        if(Input.GetKeyDown("put any letter here!")){   //(Example: Input.GetKeyDown("c"))
            cameraSwitch =!cameraSwitch;
        }

        Note: The "if" statement is used for a condition, the mechanic will only work when the condition is fullfilled. 
              (Example: if you press button "c", the camera will switch to other camera)
              Input.GetKeyDown("") is the condition for the camera switch. 
              cameraSwitch = !cameraSwitch;, this line is what turns the bool true or false like on and off on light bulb switch.
              (This can be also put OnTriggerEnter lines)

        if(cameraSwtich == true){

		camera_a.GetComponent<Camera>().enabled = false;
		camera_b.GetComponent<Camera>().enabled = true;
		}
		
		else if (cameraSwtich == false){
		camera_a.GetComponent<Camera>().enabled = true;
		camera_b.GetComponent<Camera>().enabled = false;
		}

        Note: This is another condition, if the cameraSwitch bool is false, the camera_a will turn off and the camera_b will turn on and vice verse!
              The line code above will result to camera switch like how any other switch or lever we see on the real life.


        Overall the code will look like this:

        using System.Collections;
        using System.Collections.Generic;
        using UnityEngine;

        public class cam_switch : MonoBehaviour {

	        [SerializeField]
	        Camera camera_a;
	        [SerializeField]
	        Camera camera_b;

        	private bool cameraSwtich = false;

        	void Start () {
        		camera_a.GetComponent<Camera>().enabled = true;
        		camera_b.GetComponent<Camera>().enabled = false;
		
        	}
	
        	void Update () {

        		if(Input.GetKeyDown("c")){
        			cameraSwtich = !cameraSwtich;
        		}

        		if(cameraSwtich == true){

	        	camera_a.GetComponent<Camera>().enabled = false;
		        camera_b.GetComponent<Camera>().enabled = true;
	        	}
		
		        else if (cameraSwtich == false){
		        camera_a.GetComponent<Camera>().enabled = true;
		        camera_b.GetComponent<Camera>().enabled = false;
		        }
        	}
        }

5.) Done!

    This is the end of this instruction on how to make a camera switch works.



        



