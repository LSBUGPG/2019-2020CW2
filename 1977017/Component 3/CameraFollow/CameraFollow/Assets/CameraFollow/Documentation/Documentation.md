# CameraFollow Documentation

This documentation explains how this component works and how the camera follow the sphere.

## Behaviours
- ['FixedUpdate()']


## FixedUpdate()

This function demonstrates that in ['FixedUpdate'] I used the vector variable ['desiredPosition'] on the ['target'] public variable which in this case is the sphere gameObject followed by an ['offset'] to keep it smooth. The camera is also smoothed using a ['Vector3.Lerp'] utilizing the transform position and desired position as well as the ['smoothSpeed'] to get a smooth camera movement.

**Intended Use**
This can be used from anything from a character moving in a scene to tracking and object, its not soul depedant on a camera object. For instance if I wanted to attach this to a gun firing at a player, it will track the player.

## Example Scene(s)

In the `ExampleScene` folder contains the examplescene that was set up utlizing the behaviours in this package.

- [`ExampleScene`]

### ExampleScene

This example demonstrates the use of behaviours in this package. For the one behaviour used, it follows a target to its rest which is the sphere falling.

The ball's state of motion is tracked by the camera.



[`ExampleScene`]: #ExampleScene

['FixedUpdate()']: https://docs.unity3d.com/ScriptReference/PlayerLoop.FixedUpdate.html
['target']: https://docs.unity3d.com/ScriptReference/GraphicsBuffer.Target.html
['offset']: #offset
['smoothSpeed']: #smoothSpeed
['Vector3.Lerp']: https://docs.unity3d.com/ScriptReference/Vector3.Lerp.html