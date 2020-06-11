ANOTHER CAMERA MIMICKING THE PLAYER CONTROLLER'S MOVEMENT AND ROTATION

1.) Prepare a unity project

    On new unity project or existing one, create two camera on the scene.
    Right click on the "Hierarchy" tab and click Camera.
    Rename the two cameras. (Example: "player_camera", "mimic_camera")
    Add a player controller.
    (Any player-type asset you could control, first person viewpoint is prefered.)
    Use "player_camera" as your player's first person viewpiont camera.
    Place "mimic_camera" parallel to your player controller. (You can put in anywhere you like, this is just formality)
    Right click on your "Hierarchy" and click create empty, make 2 of them. 
    Rename the 2 empty game object whatever you like. (Example: "player_point", "mimic_point")
    Click your "mimic_camera", on the "Inspector", click add component then new script.
    (Creating new script could be also be done by right clicking on the "Project" tab, create then "C# Script ")
    Rename your new script.(Example: "camera_mimicking")

2.) Creating a script for camera mimic

    Use the code below:
    
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class camera_mimicking : MonoBehaviour
    {
        public Transform playerCamera;
        public Transform mimicPoint;
        public Transform playerPoint;

        void Update()
        {
            Vector3 playerOffsetFromPoint = playerCamera.position - playerPoint.position;
            transform.position = mimicPoint.position + playerOffsetFromPoint;

            float angularDifferenceBetweenPointRotations = Quaternion.Angle(mimicPoint.rotation, playerPoint.rotation);

            Quaternion pointRotationalDifference = Quaternion.AngleAxis(angularDifferenceBetweenPointRotations, Vector3.up);
            Vector3 newCameraDirection = pointRotationalDifference * playerCamera.forward;
            transform.rotation = Quaternion.LookRotation(newCameraDirection, Vector3.up);
        }
    }

    Note: What this code do is it look the position of the "player controller" from the "player_point" gameobject so your "mimic_camera" could replicate it by using "mimic_point" gameobject as center point.
 
 3.) Finalizing your component

      Click your "mimic_camera", on the "Inspector", find the "camera_mimicking" script component.
      Drag your player controller into the box beside the "Player Camera".
      Same as the step above, drag mimic_point gameobject into the box beside "Mimic Point" as well as the "player_point" into the box beside "Player Point".

      Note: Make sure you drag these components at the right place.

4.) Done!

    This is the end of this instruction on how to make another camera mimic your player's camera.