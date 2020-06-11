# Game-Project
Components Project for Programming CourseWork 2

This game project is made of 4 packages:

- Player and Enemy Movement
- Third Person Camera Behaviour
- Player and Enemy Shooting System
- Player and Enemy Health System

The first package enables the player and the enemy to move in the visible area, where you can control the player while the enemy follows you and tries to catch you.

The second behaviour consists in a test scene where you can try the third person camera, which is pivoting around the player (with a certain offset) with your mouse.

The third package shows how the fighting system works. You, as the player, can shoot through your camera's raycasts helped by a UI target. Meanwhile the enemy can shoot back with 
a constant rate if he's already following you.

The fourth package is aimed to work on the player's and enemy's health. They both have 3 health points and every hit is equal to -1 health points. The number of health points is 
editable in the script for the player and in the inspector for the enemy. Once their health reaches 0 or less than 0: the player is destroyed; the enemy "turns off" (both his health 
script and moving script are deleted, but not the gameObject)

In the end these packages make a simple Third Person Ranged Combat System which can be edited depending on the user's preferences.



