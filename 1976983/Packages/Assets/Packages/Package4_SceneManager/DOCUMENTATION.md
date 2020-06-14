# Respawn User Guide

This document explains how to use the behaviours in this package to create a Start Menu that allows the player to click  a `Play` button to change the scene.

## Behaviours

- C1_Menu

### Respawn

This behaviour allows the player to click  a `Play` button to change the scene. It also uses `UnityEngine.SceneManagement` in order to move between scenes.

**Intended use:** to be added to a Canvas to change scenes, it can also be reused and altered to change back and forth between scenes. To use correctly: follow instructions in `Empty Scene` down below.


## Example Folder

The `Examples` folder contains a Unity scene set up for testing the behaviours in this package alongside some art assets to help visualise the behaviours better.

- Scenes Folder
- Asset Folder

### Scene Folder

These scenes demonstrats the intended use of the behaviours in this package.

- Game Scene
- Empty Scene

#### Test Scene

The scene is to be used alongisde the `Empty` scene.

#### Empty Scene

This is an empty scene in which you can use the art assets provided in the `Assets` folder and the package to create and test out your own scene.

Begin by right-clicking in the `Hierachy` and scroll over `UI`, and then select `Panel`. Rename the Panel to `Background`. Rename the Canvas to `MenuOptions`.

In the `Background` inspector, select the Color under the Image component and drag the alpha channel up to 100. Here you can select a colour. If you want to add your own image to the background rather than a plain colour, simply save the image to the Assets folder, check in the inspector that the Texture Type is set to Sprite (2D and UI), drag the image into the Source Image tab in the Image component, and ensure that the Alpha chanel is at 100 too.

Right-click on the Hierachy and go to UI>Button. Resize and reposition this button however you would like. In the hierachy, rename the button to `PlayButton`.

In the inspector under Image, change the colour of the button to black. As we want it to indicate to the player that it is in fact a button, we are going to alter it's colour based on different variables. When the button is not being interacted with, it will not show, so under Normal Color in the Button (Script) component change the alpha channel to 0. When the button is hovered over with the cursor, we want the button to be visable, but not fully opaque. To do this, change the Highlighted Color to 60 in the alpha channel. Finally, when the button is selected, we want the button to be even clearer. We do this by changing the Pressed Color alpha channel to 100. In the inspector, simply change the "New Text" in the Text Input Box to Play. You can edit and adjust the text here, so feel free to play around and make it look nice.

Drag and drop the `C1_Menu` script onto the `MenuOptions` canvas. Next, select `File` > `Build Settings...`, then drag the `Empty` scene from the project window into the Scene Manager window. Then repeat this for the scene you wish to play next, in this example the `Game Scene`.

Close out of the window once that is completed and select the `PlayButton` in the `Hierachy`. In the inspector, find the the list `OnClick` under the header `Button (Script)`. Click on the plus button and drag the `MenuOption`s object into the empty slot. Select the drop down list `No Function`s and select `Menu` > `PlayGame ()`.

### Asset Folder

This folder contains art assets found within the Example Scene as well as a prefab for a playable version of the Player sprite and the Collectable sprite.
