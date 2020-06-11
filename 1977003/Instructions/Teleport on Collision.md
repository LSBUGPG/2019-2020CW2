TELEPORTING PLAYER CONTROLLER ON COLLISION

1.) Prepare a unity project
        
    On existing or newly created unity project, add any player controller. 
    (Any player-type asset you could control, first person viewpoint or third person viewpoint)
    Right click on your "Hierarchy" tab and create a mesh where you want to collide with, make sure to set the mesh collider "Is trigger" checked.
    Rename your mesh to anything you like.(Example: "entry_point")
    On your "Hierarchy" tab still, right click and choose create empty.
    Rename your empty gameobject.(Example: "exit_point")
    Click your "entry_point" and on the "Inspector" tab, click add component then new script and rename it. (Example: "teleport_on_collision")
    (Creating new script could be also be done by right clicking on the "Project" tab, create then "C# Script ")

    Note: The mesh "entry_point" will be the object you need to collide with to teleport and the "exit_point" is the position where your FP Controller will be teleported.


2.) Creating a script for teleport on collision

    Use the code below:

    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class teleport_on_collision : MonoBehaviour
    {
        public GameObject exitPoint;

        void OnTriggerEnter(Collider other) {

            if(other.tag == "Player") {

                other.transform.position = exitPoint.transform.position + exitPoint.transform.forward * 1;
            }
        }
    }

    Note: Make sure you tag your FP Controller as "Player", it is located below the your FP Controller name in "Inspector".
          If you are using character controller component in your FP Controller, make sure you check "Auto Sync Transform" in "Edit" then "Project Settings" and finally at "Physics" tab.

3.) Finalizing your component

    Click your "entry_point" mesh and find your "teleport_on_collision" script component in your "Inspector".
    Drag your "exit_point" towards the box beside "Exit Point".

4.) Done!

    This is the end of this instruction on how to teleport your FP Controller.


