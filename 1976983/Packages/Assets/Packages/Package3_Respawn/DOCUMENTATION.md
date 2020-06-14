# Respawn User Guide

This document explains how to use the behaviours in this package to create a Respawn System that allows the player pbject to repawn at the beginning of the level with up to three lives.

## Behaviours

- C1_Respawn

### Respawn

This behaviour allows the player to respawn after colliding with a designated `Respawn` trigger up to 3 times. It also uses `Text` in unity's UI in order to display the remaining lives, as well as informing the player that they lost after reaching 0 lives.

**Intended use:** to be added to an empty game object that will be a respawn point. To use correctly: follow instructions in `Empty Scene` down below.


## Example Folder

The `Examples` folder contains a Unity scene set up for testing the behaviours in this package alongside some art assets to help visualise the behaviours better.

- Scenes Folder
- Asset Folder

### Scene Folder

These scenes demonstrats the intended use of the behaviours in this package.

- Test Scene
- Empty Scene

#### Test Scene

The scene is already completed and you only have to press play and move the `Player` GameObject into the `RespawnTrigger` game object to see the player respawn.

#### Empty Scene

This is an empty scene in which you can use the art assets provided in the `Assets` folder and the package to create and test out your own scene.

Begin by creating an empty game object in the `Hierachy`, and rename it `RespawnTrigger`. Add a box collider to it and edit the size to encompass the size you would like.

Now, make another empty game object and rename this `RespawnPoint`. Move it where you want the player character to respawn.

Next, create a `Player` gameObject by creating an empty game object, and, if you would like to, add a `Sprite Renderer` component to it in the `Inspector`. You could use your own art asset her or the one provided in the `Asset` folder. Or you could leave it as an empty game object. Then you will need to add a collider to the `Player` and this can this can be a box, circle capsule shape, it's up to you and what you think will best. You will also need to change the `Player` GameObject's tag to be `Player`.

Next, you will need to create the text that will display the lives and the `You Lose` statement. You can do this by right clicking the Hierachy, selecting UI > Text. Do this twice, renaming one to `Lives` and the other to `LoseText`.

Finally, you can add the `C1_Respawn` Script to the `RespawnTrigger`, ensuring you drag the `PLayer` GameObject to the `Player` slot, the `RespawnPoint` empty GameObject to the `Respawn Point` slot, the `Lives` Text into the `lifeCountText` slot and the `LoseText` Text into the `loseText` slot.

### Asset Folder

This folder contains art assets found within the Example Scene as well as a prefab for a playable version of the Player sprite and the Collectable sprite.
