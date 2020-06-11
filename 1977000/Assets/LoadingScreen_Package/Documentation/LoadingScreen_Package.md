# Loading Screen Package

This package allows to put customise and add a bit of polish to the game by adding the loading screen with the loading bar between the scenes. The package includes several pre-made prefabs and png buttons to add to the scene.
The scripts also allows to add and play animations in the scene. 

### Package contents:

- **Documentation folder:** 
Includes documentation that shows how to use the component.

- **Examples folder**
Includes Two test scenes,  Sprites Folder and Prefabs folder.  
Sprites folder includes 2D Sprites for the test scenes.
Prefabs folder includes animated 2D sprite, slider and button.

- **Scripts folder**
Includes **Loading Screen** script. 

### Instructions

1. Create the new Canvas (UI-> Canvas)#
2. Add the **"LoadingScreen"** script to it. 
3. Create the button for this Canvas (UI->Button). 
4. In the "On click" menu in the button's inspector drag the Canvas.(from 1.) 
   In the function drop down menu select new "LoadingScreen" function and then-> Load ().

5. Create new Canvas. (Let's name it Loading Canvas)
6. Drag the premade Slider from the prefabs folder to the scene.

7. Select the First Canvas with the Script. 
7.1 In the Script menu in the "Load Level" write the name of the Scene, that should be loaded (make sure it is added in the buil settings).
7.2 In the Loading Screen drag the new Loading Canvas.
7.3. Bring the Slider to the "Bar"

***As the loading bar in the test scene loads too fast (lightweight next scene) the scene appears when you press any key.
If you want to load the scene automatically after loading bar is full - delete the following code from the script:***
```
if (Input.anyKeyDown)                            
 {                                                         
    asyncLoad.allowSceneActivation = true;              
 }   
```
