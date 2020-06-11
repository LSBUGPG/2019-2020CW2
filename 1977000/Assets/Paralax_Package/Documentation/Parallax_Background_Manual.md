# Parallax Background Package

This package allows creating beautiful parallax effect for the background, that will create a volume effect for the scene.
It's possible to add as many background elements as preferable. 
With this asset would be possible to switch on/off the parallax and scrolling effect. 
Besides, the script allows to manually change the speed for each parallax element, which makes the scene fully adjustable for the perfect look. 

Furthermore, this package also includes scripts for the Camera and Player Movement, which will allow to set up the scene quickly, or at least instantly test the parallax effect. 

### Package contents:

- **Documentation folder:** 
Includes documentation that shows how to use the component.

- **Examples folder**
Includes Test Scene and Sprites Folder. 
Sprites folder include 2D Sprites for the test scene and Player's material. 

- **Scripts folder**
Includes **Scrolling** (parallax) **Camera Movement** and **Player Controller** scripts. 

### Instructions

*If the scene is setted-up, player and camera are movable, go to **Step 4*** 

### Step 1. Setting up the Scene.

Create and bring the player and ground sprites to the scene (You can use the ones from examples folder for the test)
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

### Step 3. Scrolling and parallax effect.

1. Bring to the scene the layer of background. Reset its  position in the Inspector. 
2. Dublicate it and move direcly via the X Axis to the right, until both elements will stand without a seam between each other.
3. Round the number in the Inspector on the Position of X-axis. *(For example, 25,2 -> 25)* 
4. Duplicate the last element and add the minus(-) to make the number negative in the X Axis. *(For example, 25 -> - 25)*
As a result, you should have three background elements standing seamlessly next to each other.

5. Create a new empty GameObject, reset its position in the Inspector.
6. Drag all three background elements to this GameObject. The elements should be in the right order, where the left element is the first and the right is the last.:
```
↓ Empty Game Object
        1. left element
        2. middle element
        3. right element
```
7. Select the main GameObject and add the **Scrolling script** to it.
*Tick both Scrolling and Parallax for Parallax Effect.*
*Untick the parallax if you don't require the scrolling delay. (for example, for the sky or ground ).*
8. In the **Background Size** put the number of the background element size 
( the number from the X Axis of the element *(in this example it was 25)*).
9. In the **Parallax Speed** write the number smaller the 1 (1 is the speed of the player, so the background elements would be slower)

***3.1. If the sprite needs to be repositioned from the resetted position (for example, ground, trees, bushes, etc.).***

Bring to the scene the layer of background. Reset its  position in the Inspector and after adjust size and position it as needed.
Repeat the steps **2-6**
Create new Empty GameObject. Reset it's position. 
Dublicate it twice and only add the numbers to the dublicates in the X Axis from the step 3-4 *(in this example it was 25)*.
*Now you have three Game Objects, that are positioned above your three background elements.*
Bring those Game Objects to the main Game Object. And in each of the ***NEW*** Created Game Object bring the background elements. Put them in the right order from left to right:
```
  ↓Empty Game Object
        1. ↓ left Game Object
                left background element
        2.↓ middle Game Object
                middle background element
        3. ↓ right Game Object
                right background element
```
Continue with Steps 7-9.

**Result**

If the scene setup correctly, the new background element will appear when the player will approach the edge of the middle element.
Don't forget to adjust the correct Order in Layer in the Inspector for each element!



