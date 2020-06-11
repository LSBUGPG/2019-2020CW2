# Player Movement Package

This package allows creating a complete player controller in Unity with the adjustable settings for multiple jumping.
This package also includes adjustable settings for speed and jump force.

### Package contents:

- **Documentation folder:** 
Includes documentation that shows how to use the component.

- **Examples folder**
Includes Test Scene and Sprites Folder. 
Sprites folder include 2D Sprites for the test scene and Player's material. 

- **Scripts folder**
Includes **Player Controller** script. 

### Instructions

### Step 1. Setting up the Scene.

Create and bring the player, ground and the background sprites to the scene (You can use the ones from examples folder for the test)
Create Box Collider 2D for the ground. (And for all the items that would be jumped/moved on)
Create the new layer for the floor And for all the items that would be jumped/moved on and name it **ground**.

### Step 2. Making the Player Movable.

Create the Box Collider2D for the Player.
Create the RigidBody for the Player. Create a new Material for the player with 0 (zero) Friction and Bounciness. 
Drag it to "Material" in the player's RigidBody. 

Select the player and click and drag the **PlayerController** Script from the **Scripts** folder.
Select the player and create an **empty GameObject**. Move it just under the player's legs and name it "ground_check".

**Adgust the settings for the player in the Script Component:**
Bring the "ground_check" object to the Ground Check Cell. 
Select the new created layer "ground" in the "What is Ground" Cell.
Change the Speed and Jump force. 
Write the number for the Extra Jump Value (Minimum 1). This allows you to make multiple jumps. 
