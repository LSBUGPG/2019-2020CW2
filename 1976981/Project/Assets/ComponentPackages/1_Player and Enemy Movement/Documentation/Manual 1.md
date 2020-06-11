
# Player and Enemy Movement user guide

This document explains how to use the behaviours in this package and how to make the player move in the visible area, while the enemy chases him.
--------------------------------------------------------------------------------------------------------------------------------
## Behaviours

- [`PlayerMovemement`]
- [`EnemyFollow`]
--------------------------------------------------------------------------------------------------------------------------------

## PlayerMovement

This behaviour should be applied to the Player. It allows you to move the player across the screen with the W-A-S-D keys or with the arrow keys. It is composed by 3 elements:

- Speed
- Rb
- JumpForce

###Speed

Insert a value in the speed box in order to move the Player. The higher the number, the faster the player. **If the number is negative the player will move in the opposite direction**

###Rb

Drag in the Rb box the player's Rigidbody, so the script will be able to use the player's rigidbody velocity to move it.

###JumpForce

In the jumpforce component type a positive number so the player will be able to jump by pressing the spacebar. The higher the number, the higher the player will jump. **A negative value will push the player downwards**

--------------------------------------------------------------------------------------------------------------------------------

## EnemyFollow

This behaviour has to be given to the Enemy. It allows the enemy to follow the player as soon as he enters the enemy's detection area. Its elements are:

- The Player
- Detection distance
- Is Following

### The Player

In The Player box drag in or select (clicking on the circle on the right) the player's gameobject, so in this way the enemy will know who to follow.

### Detection Distance

The detection distance sets the distance in which the enemy is able to detect the player's gameobject: the higher the number, the greater will the enemy's trigger zone be.

### Is Following

The isFollowing unchecked box must remain unchecked. It represents a bool which inside the script determines if the enemy is following the player or not. It will turn on automatically during gameplay when the player enters the trigger zone.

**To modify the enemy's speed, acceleration etc. change the values in the Nav Mesh Agent component in the enemy's Inspector.**


--------------------------------------------------------------------------------------------------------------------------------

[`PlayerMovement`]: #PlayerMovement
[`EnemyFollow`]: #EnemyFollow
