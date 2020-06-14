# 2D Movement User Guide

This document explains how to use the behaviours in this package to create a 2D character controller that can move smoothly and jump using physics.

## Components

- C1_2DController
- C2_Movement

### Component 1 - 2D Character Controller

This component creates variables for the player sprite to test for. For example, the controller uses `Booleans` to see if the player character is `grounded` and even flips the player to face the correct direction when moving. This is to be used in conjunction with Component 2 - Movement and Jumping. This controller creates a number of variables that you can adjust within the Inspector to attain your perfect results.


**Intended use:** to create variables to see if the player is able to jump, move, jump and move together, and change character sprites direction. To use correctly: See `Empty Scene` below.

### Component 2 - Movement and Jumping

This behaviour allows the character to move on the horizontal axis and jump using unity's built in inputs of `Jump` and `Horizontal` obtained using `GetButtonDown` and `GetAxisRaw` respectively. It utilises the `controller` component previously described. The component also makes use of the `Move` function in order to implement the `Horizontal` axis and `Jump` Inputs referenced.

**Intended use:** To make the player sprite move and jump, as well as flip the art asset used to face the direction of movement. To use correctly: See `Empty Scene` below.

## Example Folder

The `Examples` folder contains a number of Unity scenes set up for testing the behaviours in this package alongside some art assets to help visualise the behaviours better.

- Package1_ExampleScene
- Asset Folder


### Example Scene

 - Test Scene
 - Empty Scene
 
#### Test

The scene is already completed and you only have to press play to see that it works 

#### Empty

An empty Scene to test the component out from scratch. 

Begin by creating an empty game object, and rename this `Player`. You can test this component without any visuals, but if you would like to see the `Player` object move around, simply Add Component > Sprite Renderer, and then drag the 2D Sprite named `Player` in the `Assets` folder and drop it into the `Sprite` option in the Sprite Renderer component in the Inspector. Or you can import your own art assets. You can then scale the `Player` gameObject to your desired size using the Transform component in the Inspector.

Then add a new Component > RigidBody2D. You also need to add a Collider2D, this can be a box, circle capsule shape, it's up to you and what you think will best. Within the Inspector, select the `Layer` option and then `Add Layer...` From here, create a new Layer called `Player` and return the the `Player` gameObject Inspector to change the Layer from `Default` to `Player`. Drag the `C1_2DController` and `C2_Movement` Scripts onto the the `Player` GameObject and under the `C1_2DController`Component, select `What is Ground` to include every Layer except the `PLayer` Layer. Right-click the `Player` GameObject and `Create Empty`, renaming it to `GroundCheck`. This should parent `GroundCheck` to the `Player` GameObject. Now simply change the position of the Y axis of the`GroundCheck` GameObject to be at the botton of the `Player` GameObject. Drag the `GroundCheck` GameObject into the `Ground Check` slot within the `C1_2DController` script on the `Player` GameObject. Finally, under the `C2_Movement` Script Component in the `Player` GameObject's Inspector, drag the `Player` GameObject into the `Controller` option.

Now you need to add a "floor" or lower collider to act as the surface the `Player` gameObject can run and jump from. Begin by creating an empty game object, and rename this `Floor`. As before, you can test this component without any visuals, but if you would like to see the `Floor` simply Add Component > Sprite Renderer, and then drag the 2D Sprite named `Floor` in the `Assets` folder and drop it into the `Sprite` option in the Sprite Renderer component in the Inspector. Or you can import your own art assets. You can then scale the `Floor` gameObject to your desired size using the Transform component in the Inspector. Then add a new Component > a Collider2D, this can be a box, circle capsule shape, it's up to you a


### Asset Folder

This folder contains art assets found within the Example Scene as well as a prefab for a playable version of the `Player` sprite.
