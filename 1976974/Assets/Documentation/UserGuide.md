# 2D Random Map User Guide

This document explains how the behaviours in this package to create a 2D game project that follows a player object with a healthbar system that has the 2D character controller with a level map generator and having an enemy AI system.

## Behaviours

- [`PlayerController`]
- [`Enemy`]
- [`Projectile`]
- [`LevelGeneration`]
- [`Health`]

### PlayerController

This behaviour tries to move the player object sprite with moveVelocity. The behaviour requires the game object to attach the dynamic body type with Rigidbody2D to move the object from different directions with a 2D viewpoint and with the right amount of speed.

**Intended use**: to place the 2d controller at the game object and have multiple directions.

### Enemy

This behaviour tries to get the Enemy AI function when the player object is near the enemy game object and uses the 'projectile' when the player game object gets near. This behaviour uses the FindObjectOfType<PlayerController> when it connects with the values of destroying objects.

**Intended use**: to aim at the player controller when the enemy gets close and activates the projectile.

### Projectile

This behaviour tries to get the projectile with the Collider2D with the enemy timing the firing rate depending on the player's movement in the package. It uses the target variable with the Vector2 values while the camera remains stationary.

**Intended use**: to enable the firing function for the enemy game object and linking it with the target, speed * Time.deltaTime.
	
### LevelGeneration

This behaviour tries to get the spawn point functional for the level generator by turning into a prefab object and using the gizmos icons and spreading it around the scene and each time the game load, it generates the sprites randomly and varies differently.

**Intended use**: to add an function for the map to generate randomly and makes the scene different.

### Health

This behaviour tries to display the number of healthbars on the canvas and using multiple images to set up the UI with the [`Health`] behaviour. It can alter the amount 'numOfHearts' and let the player game object have certain 'health' in the scene.

**Intended use**: to place the healthbar behaviour onto the [`PlayerController`] in this package.

## Scenes

The `Scenes` folder contains a number of Unity scenes set up for testing the behaviours in this package.

- [`2DMovementUpDown`]
- [`EnemyAI`]
- [`HealthbarSystem`]
- [`RandomMapGenerator`]
- [`GameProjectMaster`]

### 2DMovementUpDown
This test demonstrates just the [`PlayerController`] behaviour. It contains the circle sprite representing as the player and it showcase the 2D controller movement and letting the player control in any direction with 'speed'.

### EnemyAI

This test demonstrates just the [`Enemy`] behaviour and [`Projectile`] behaviour. It contains the circle sprite representing the player and a square sprite presenting as the enemy and positioned at each side. When running the scene, the player moves and the enemy retreats slowly at certain space while firing the projectile at the player.

### HealthbarSystem

This test demonstrates just the [`Health`] behaviour. It contains the healthbar sprites position as the player's health in the scene. It sets up the certain amount of hearts active and the empty hearts is representing the total amount of health that the player has in the scene.

### RandomMapGenerator

This test demonstrates just the [`LevelGeneration`] behaviour. It contains multiple gizmos icons spread on the scene and has varitey of sprites to fill in the scene. Each time the scene runs, the positioning and shapes changes and the player must navigate with these spawn points while facing the enemy AI.

### GameProjectMaster

This test demonstrates the combination of the four packages and turning into a functional small game project with all behaviours active and adjusted for this scene.

[`2DMovementUpDown`]: #2DMovementUpDown
[`EnemyAI`]: #EnemyAI
[`HealthbarSystem`]: #HealthbarSystem
[`RandomMapGenerator`]: #RandomMapGenerator
[`GameProjectMaster`]: #GameProjectMaster
[`PlayerController`]: #PlayerController
[`Enemy`]: #Enemy
[`Projectile`]: #Projectile
[`LevelGeneration`]: #LevelGeneration
[`Health`]: #Health