INSTANTIATING OBJECT WHERE YOUR CAMERA IS FACING

1.) Prepare a unity project

    On existing or newly created unity project, adding any player controller. 
    (Any player-type asset you could control, first person viewpoint is prefered.)
    By clicking click the "camera" that's under your FP controller, you could click add new component then new script.
    (Creating new script could be also be done by right clicking on the "Project" tab, create then "C# Script")
    Rename the script whatever you like. (Example: "instantiate_object")

2.) Creating a script for instantiating object

    Open your new script("instantiate_object").
    Under the public class, type;

    public GameObject yourObject;
    public float objectDistance = 0;

    Note: By using public on the declaration, we can access them in the script component under the "Inspector".
          Letting objectDistance on public as well will let you change it whatever you want under "Inspector" without reopening the script and manually change it inside.

    Under the void Update, type;

    if(Input.GetKeyCode("put any letter you like!")){   //(Example: Input.GetKeyDown("e"))

        GameObject myObject = Instantiate (yourObject, transform.position + (transform.forward * objectDistance), transform.rotation) as GameObject;
        }

    Note: By setting an Input.GetKeyCode("e"), you will bind the instantiate button to letter "e" button on the keyboard. (This will apply to any letter of your liking!)
          Instantiate() will be your line for summoning your object.
          The transform.position will let the unity engine on what position it will be instantiate, while transform.forward will always make sure it's always at the front of your camera.
          The transform.rotation make sure it was always rotated facing your camera.


    It will look like this:

    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class instantiate_object : MonoBehaviour{

    public GameObject yourObject;
    public float objectDistance = 0;

    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
             GameObject myprefab = Instantiate(wormholePrefab, transform.position + (transform.forward * objDistance), transform.rotation) as GameObject;
        }
    }


3.) Setting up component for the instantiating object

    Click your camera under your FP controller, on the "Inspector" look at your "instantiate_object" script component.
    Drag the object you want to instantiate on the box beside your "Your Object".
    Setup up the objectDistance on your liking. (This is how far your object will be instantiate from your camera)

4.) Done!

    This is the end of this instruction on how to instantiate an object where your camera is facing.





    



