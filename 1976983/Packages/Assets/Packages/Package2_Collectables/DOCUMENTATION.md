# Collection User Guide

This document explains how to use the behaviours in this package to create a Object Collection System that allows you to create collectable objects and create a score with a win condition text. You can change the number needed to produce the `WinText` in the hierachy of the `Player Object`.

## Behaviours

- OnTriggerEnter
- SetCountText

### OnTriggerEnter

This behaviour allows the player to collide with the collectables which then get `Destroyed`. It also begins counting the number of coins the player has collected

**Intended use:** to create a collectable system with and keep track of the score. To use correctly: follow instructions in `Empty Scene` down below.

### SetCountText

This behaviour displays the number of `Coins` collected using `UnityEngine.UI`, and also display's a win condition text to appear.

**Intended use:** to display the `Player`'s score in game, as well as tell the player they have won the game. To use correctly: follow instructions in `Empty Scene` down below.

## Example Folder

The `Examples` folder contains a Unity scene set up for testing the behaviours in this package alongside some art assets to help visualise the behaviours better.

- Scenes Folder
- Assets Folder

### Scenes Folder

This test demonstrates the intended use of the behaviours in this package. 

- Test Scene
- Empty Scene

#### Test Scene
The scene is already completed and you only have to press play and drag the `Player` GameObject over the `Coin` GameObjects in the Scene view to test that it works.

#### Empty Scene
Begin by creating an empty game object, and rename this `Coin`. You can test this component without any visuals, but if you would like to see the `Coin` object be collected, simply Add Component > Sprite Renderer, and then drag the 2D Sprite named `Coin` in the `Assets` folder and drop it into the `Sprite` option in the Sprite Renderer component in the Inspector. Or you can import your own art assets. 

You can then scale the `Coin` gameObject to your desired size using the Transform component in the Inspector.
Then add a new Component > Collider2D, this can be a box, circle capsule shape, it's up to you and what you think will best. Under the Collider Component in the Inspector, ensure that the `Is Trigger` option has been ticked.Within the Inspector, select the `Tag` option and then `Add Tag...` From here, create a new Tag called `Coin` and return the the `Coin` gameObject Inspector to change the Tag from `Untagged` to `Coin`.

If you would like to use your own player character, please do so here. You must ensure that the Player GameObject has a 2DCollider that best matches it, a RigidBody2D, and the `C1_Collectable` Script attached to it. To test the script easily, you can set the Rigidbody2D's `Body Type` to Kinematic. 

Then you will need to right click the Hierachy, select UI > Text. Do this twice, renaming one to `Score` and the other to `WinText`. Then drag the `Score` Text into the `Count Text` Slot, and the `WinText` Text into the `Win Text` slot in the `C1_Collectable` Script Component in the `Player` GameObject Hierachy.

Finally, play the scene with the scene view selected, and drag the `PLayer` GameObject over the `Coin` GameObject.


### Asset Folder

This folder contains art assets found within the Example Scene as well as a prefab for a playable version of the Player sprite and the Collectable sprite.
