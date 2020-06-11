//2D Camera to 3D Camera Documentation:

//How this code is meant to work is the following; when the player presses the C key,
//    the camera switches perspective, from 2D to 3D.

//    To do this, you must do the following:

//        //public Transform player;

////public Camera firstPersonCam, thirdPersonCam;

//    Both of these lines mean that each of these variables are now available to edit in Unity instead of Visual Studio.
//    The variables mean the following;

//    player = the character that the player controls.
//    firstPersonCam = the camera in the 2D perspective.
//    thirdPersonCam: the camera in the 3D perspective.

//        //public KeyCode cKey;

////public bool camSwitch = false;

    //These next lines are more of the same; the first line makes the key that the player presses to switch camera angles public.
   
    //However, the next line is slightly different; bools are a true/false function, and since it is also made public,
    //we can edit this through Unity. The whole line essentially asks if we want to turn the camera switch (aka camSwitch) function on or off.
    //    If it is turned on then we are saying we want the switch to happen in the game. But if it is switched off, it will not work.

    //    Moving on to the final part of the code, it reads as the following:

    ////            if (Input.GetKeyDown(cKey))
    ////    {
    ////camSwitch = !camSwitch;
    ////firstPersonCam.gameObject.SetActive(camSwitch);
    ////thirdPersonCam.gameObject.SetActive(!camSwitch);

    //First, the if statement; this first line means that "if the player presses the C key..." then something will happen.

        //The next line is a "toggle," which means that if the condition of the if statement is met (shown above), this function will happen.
        //In this case, the code says "Set the camera to the opposite of what it is currently."
        //For example, if the camera is set to first person, pressing the C key will switch it to third person, and vice versa.