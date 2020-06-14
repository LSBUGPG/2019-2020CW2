# CameraFollow Documentation

This documentation explains how this component works and how the camera follow the sphere.

## Behaviours
- ['Awake()']
- ['OnCollisionEnter()']


## Awake()

This function captures ['fixedDeltaTime'] the current interval in seconds of the physics tied updates.

## OnCollisionEnter()

This function demonstrates the use of the if statement ['collision.gameObject.tag'] which searches for the desired tag ["Stop"]. If a collision occurs between the sphere (the object the script is attached to) and cube (which is purposely tilted to illustrate the effect) then the game engine's physics will be put at the value 0 with ['Time.timeScale'] and ['Debug.Log'] to get feedback on the event.

**Intended Use**
Normally used for pause menus but can be tweaked to slow the game down based on input or player movement. In this case it is used to stop the ball falling off of the tilted cube demonstrating it working.

## Example Scene(s)

In the `ExampleScene` folder contains the examplescene that was set up utlizing the behaviours in this package.

- [`ExampleScene`]

### ExampleScene

This example demonstrates the use of behaviours in this package. For the behaviours used, it changes the Time.timescale of the game engine's physics in order to stop the ball from falling off.



[`ExampleScene`]: #ExampleScene

[`Collision`]: https://docs.unity3d.com/ScriptReference/Collision.html
['OnCollisionEnter']: https://docs.unity3d.com/ScriptReference/Collider.OnCollisionEnter.html
['Time.timeScale']: https://docs.unity3d.com/ScriptReference/Time-timeScale.html
['Awake()']: https://docs.unity3d.com/ScriptReference/MonoBehaviour.Awake.html
['Debug.Log']: https://docs.unity3d.com/ScriptReference/Debug.Log.html
['Time.fixedDeltaTime']:https://docs.unity3d.com/ScriptReference/Time-fixedDeltaTime.html
['gameObject.tag']: https://docs.unity3d.com/ScriptReference/GameObject-tag.html