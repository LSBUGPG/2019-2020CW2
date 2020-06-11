
# Player and Enemy Health System user guide

This document shows the process behind the behaviours in the 4th package, where the player and the enemy fight while they have an health system.
--------------------------------------------------------------------------------------------------------------------------------
## Behaviours

- [`EnemyFollow`]*
- [`CameraThirdPerson`]**
- [`Shooting`]***
- [`EnemyShooting`]***
- [`BulletScript`]***
- [`EnemyBulletScript`]***
- [`PlayerHealth`]
- [`EnemyHealthSystem`]

--------------------------------------------------------------------------------------------------------------------------------

*	Behaviour present also in the 1st package and manual.
**  Behaviour present also in the 2nd package and manual.
*** Behaviour present also in the 3rd package and manual.
 
--------------------------------------------------------------------------------------------------------------------------------

## CameraThirdPerson**

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

## EnemyFollow*

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

## Shooting***

Give this script to the Main Camera. It gives the player the ability to shoot using the player as a spawn for the bullets and the main camera's raycasts hit spots as a target. It's made of 3 features:

- Player
- Bullet prefab
- Force

### Player

Drag in the player gameobject of which the script will use the transform as a spawn for the bullets.

### Bullet Prefab

Select or drag inside the bullet prefab box the prefab you want to shoot and use as a prefab, in this case the prefab "Sphere Play".

### Force

The force is a value which indicates the speed at which the bullet travels. The higher the number, the faster it travels. **With a negative value it will travel in the opposite shooting direction**


--------------------------------------------------------------------------------------------------------------------------------

## EnemyShooting***

Apply this script to the Enemy. It will allow the enemy to fire back the player. In the inspector we can see 2 elements:

- Bullet
- Bulletspawn

### Bullett

Select or drag in the Bullet's box the prefab you want the enemy to shoot, in this case the prefab "Enemy Sphere".

### BulletSpawn

This element sets the position from where the enemy bullets will be spawned. Drag in here from the Hierarchy the gameObject you want the bullets to be spawned from.
In this case select the gameobject "BulletSpawn" inside the "Enemy" gameobject.


--------------------------------------------------------------------------------------------------------------------------------

## BulletScript***

This script should be applied to the Player's bullet prefab. It destroys the player bullets prefab as soon as it touches objects with tag = Ground.

 
--------------------------------------------------------------------------------------------------------------------------------

## EnemyBulletScript***

Apply this behaviour to the enemy's  prefab. It, instead, manages the enemy bullets behaviours with 2 components: 

- Speed
- Player

###Speed

With this feature you are able to manage the bullet's velocity. Select a positive value to put in the speed's box. **A negative value will make the bullet travel in the opposite aiming direction**

###Player

This element searches and finds the gameobject "Player" to which the bullet has to travel towards, to then stop at the position the "Player" gameobject was during the bullet spawning.
Drag in its box the Player gameobject. As soon as the bullet collides with the player, it destroys itself through OnTrigger.


--------------------------------------------------------------------------------------------------------------------------------

## PlayerHealth

This script needs to be on the Player. It manages the player's health in a way that: the initial health is 3 and every time the player is hit by the enemy bullets it decreases by 1.
If the health reaches 0 or it's minor than 0 zero, the player gameobject is destroyed.


--------------------------------------------------------------------------------------------------------------------------------

## EnemyHealthSystem

This behaviour instead needs to be on the Enemy. It manages the enemy's health and works in the same way the player's health one does. 
The only difference is that the enemy health decreases by 1 whenever the enemy is hit by the player's bullet, and also that the script, once the health reaches zero, destroys the enemy movement and shooting behaviours. It's composed by:

- Enemy Health

###Enemy Health

Insert a value in the box and it will be the maximum enemy's health. **Inserting a negative value will consist in the immediate destruction of the Enemy**


--------------------------------------------------------------------------------------------------------------------------------
[`CameraThirdPerson`]: #CameraThirdPerson
[`Shooting`]: #Shooting
[`EnemyShooting`]: #EnemyShooting
[`EnemyFollow`]: #EnemyFollow
[`BulletScript`]: #BulletScript
[`EnemyBulletScript`]: #EnemyBullttScript
[`PlayerHealth`]: #PlayerHealth
[`EnemyHealthSystem`]: #EnemyHealthSystem

