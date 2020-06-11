
# Third Person Camera user guide

This document indicates how to use the Main Camera's script which tilts and pans the ingame camera attached to the player.
--------------------------------------------------------------------------------------------------------------------------------

## Behaviours

- [`CameraThirdPerson`]

--------------------------------------------------------------------------------------------------------------------------------

## CameraThirdPerson

Apply this behaviour to the Main Camera. It allows you to tilt and pan the camera with your mouse. The script is made by 5 components:

- ObjectToFollow
- Speed
- Look At
- Cam Transform
- Offset

###ObjectToFollow

Drag in from the Hierarchy the player gameobject. This component will make the camera follow the player in case he will move around the map.

###Speed

The speed sets how fast the camera will rotate when you move the mouse cursor. Type a positive value, otherwise the camera will rotate in the opposite direction.

###Look At

Select in the Hierarchy the player gameobject and drag it in the Look At box. This way the camera will always look towards the player position(transform).

###Cam Transform

Drag inside the Cam Transform's box the camera's Transform component, so this way the script will be able to move and rotate the camera around the player using the main camera's coordinates.

###Offset

The offset is needed in this package because it will give a little offset to the camera's sight, otherwise it will look precisely at the player's 3D mesh not making the package work properly.
So change the offset values while ingame to have a preview, then outside the gameplay type again your values in the inspector's offset coordinates. 


--------------------------------------------------------------------------------------------------------------------------------

[`CameraThirdPerson`]: #CameraThirdPerson
