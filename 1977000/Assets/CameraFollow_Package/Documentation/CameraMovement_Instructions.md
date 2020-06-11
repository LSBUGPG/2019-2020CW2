# Camera Folow Package

This package allows creating a pretty following camera movement with a character in Unity.
Besides, this package allows adjusting the subtleties of the camera, such as a smooth stopping and sides shift.

### Package contents:

- **Documentation folder:** 
Includes documentation that shows how to use the component.

- **Examples folder**
Includes Test Scene and Sprites Folder. 
Sprites folder include 2D Sprites for the test scene and Player's material. 

- **Scripts folder**
Includes **Camera Movement** and **Player Controller** scripts. 

### Instructions
*If the scene is setted-up and the player is movable, go to **Step 3** to install the Camera Movement straightaway.* 

### Step 1. Setting up the Scene.

Create and bring the player, ground and the background sprites to the scene (You can use the ones from examples folder for the test)
Create Box Collider 2D for the ground.
Create the new layer for the floor, and name it **ground**.

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
Write the number for the Extra Jump Value (Minimum 1). This allows you to make double, triple, etc jumps. 

### Step 3. Camera Movement.

Select the player and change the tag to the "Player".
Click and drag the **CameraController** Script from the **Scripts** folde to the Main Camera. 
Adgust the Dumping and Offsets until you are happy with the result. 
Tick "IsLeft" if the player will be moving from the right to left or if you want to have more space of the left. 










