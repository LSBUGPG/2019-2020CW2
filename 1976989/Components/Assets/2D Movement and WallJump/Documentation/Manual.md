# 2D Movement and Wall Jump user guide

This document explains the behaviours contained in this package and describes how to use them to allow the character to wall jump and move in a 2D project.

## Behaviours

- [`characterMovement`]

## characterMovement

This behaviour should only need to be placed on the object/character which moves. It is a behaviour which allows an object to move side to side, jump, wall jump, and also slide down walls.

There are several configurable parameters in this behaviour which all impact the object's movement, and therefore all require a rigidbody2D to be on the object which the script is on.
The object also requires a box collider 2D.

These configurable parameters include:

- Movement Speed
- Jump Force
- Ground Check Radius
- (Transform) Ground Check
- Wall Check Distance 
- (Transform) Wall Check
- Wall Hop Force
- Wall Jump Force
- Wall Sliding Speed
- (Vector2) Wall Jump Direction
- (Vector2) Wall Hop Direction
- Movement Force in Air
- Air Drag Multiplier


### Movement Speed

This parameter allows you to configure the horizontal movement speed of the object.

### Jump Force 

This parameter allows you to configure the jump speed/force of the object (or vertical movement speed), a higher number makes it jump higher.

### Ground Check Radius 

This parameter allows you to configure the ground check radius of the character, this is the distance between the character and the ground and is used to check whether the object is grounded or not. The gizmos in the script show this visibly in
the scene by drawing a circular indicator from the player character to the ground. a Ground Check gameobject placed near the feet of the character is required in the "(Transform) Ground Check" parameter for this to work.

### (Transform) Ground Check

This works hand-in-hand with the "Ground Check Radius" parameter, you must add an invisible gameobject which represents the ground check on it to be able to show the "Ground Check Radius" in the scene using gizmos (and also for the script to work).

### Wall Check Distance

This is essentially the same as the Ground Check radius, but for the wall instead. It is the distance between the player and the wall. However, instead of a circle gizmo, this draws a line with the length "Wall Check Distance" to check
whether the player is touching the wall or not. A wall check gameobject placed on one side (right or left) of the character is required in the "(Transform) Wall Check" parameter for this to work.

### (Transform) Wall Check

This works hand-in-hand with the "Wall Check Distance" parameter, you must add an invisible gameobject which represents the wall check on it to be able to show the "Wall Check Distance" in the scene using gizmos (and also for the script to work).

### Wall Jump Force

This is the force at which the object jumps off the wall in a certain direction (left or right).

### Wall Hop Force

This is the force at which the object 'hops' off the wall when not pressing a certain direction and only jumping. Generally, this value would be less than the "Wall Jump Force".

### Wall Sliding Speed

This parameter allows you to confgure the wall sliding speed of the object. This is the speed at which it slides down a wall whilst it is touching a wall. 

### (Vector2) Wall Jump Direction

This parameter allows you to configure the direction (x and y) the object goes in when it wall jumps. 

### (Vector2) Wall Hop Direction

This parameter allows you to configure the direction (x and y) the object goes in when hopping off a wall.

### Movement Force in Air

This parameter changes the movement force whilst the character is in the air.

### Air Drag Multiplier

This parameter changes the air drag whilst the character is in the air and not using the movement keys.






