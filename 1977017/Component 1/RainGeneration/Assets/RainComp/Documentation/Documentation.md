# Rain Generator Documentation

This documentation explains how to use this specific behaviour to spawn rain prefabs with an Area of Effect cube as the spawn position and triggering its instantiation using key 'Space'.

## Behaviours

- ['SpawnRain()']
- ['OnDrawGizmosSelected()']
- [`OnCollisionEnter`]

## SpawnRain()

This function demonstrates that [`SpawnRain()`] uses [`Object.Instantiate`] to spawn the selected "Rain" prefab clone of a [`gameObject`] that was assigned through the inspector as it is set as public game object. Furthermore the use of [`Vector3`] in the [`Object.Instantiate`], gives the needed position at which it will be spawned from.

**Intended Use** To be the dependancy used for spawning the rain prefab when using the [`Input.GetKey`] if statement, the [`Space`] key is used to activate the function in order to return a spawned entity.

## OnDrawGizmosSelected()

This function demonstrates that how the [`MonoBehaviour.OnDrawGizmosSelected()`] is used to give a visual indicator of the area of effect and to render a cube object to the position I have chosen for entites to spawn.

**Intended Use**: To render a visual indication of where the random prefab spawns will be located and to have full control of where they spawn and how far they can be spawned out.

## OnCollisionEnter
This function simply allows the rain prefab to collide with [`gameObject.tag == "Ground" Object`] which will cause the rain prefab to despawn using [`Object.Destroy`].

**Intended Use**: To destroy the rain prefab when it collides with the Ground object cleaning up the scene.

## Example Scene(s)

In the `ExampleScene` folder contains the examplescene that was set up utlizing the behaviours in this package.

- [`ExampleScene`]

### ExampleScene

This example demonstrates the intended use of the behaviours in this package. It contains 4 white spheres, put together in the shape of a cloud. Slightly below the cloud you have an Empty gameObject called [`RainAOE`] which contains the [`Gizmos`] needed to view where the prefabs will spawn in the editor view.

The rain prefab itself is a simple elongated sphere [`Color'] blue. It carries a standalone script that manages the destruction based on [`Collision`] by interaction with its [`Rigidbody`] when its instantiated clone spawns from the Rain Generator script attatched to the RainAOE object.

[`SpawnRain()`]: #SpawnRain()
['OnDrawGizmosSelected()']: #OnDrawGizmosSelected()
[`OnCollisionEnter`]: #OnCollisionEnter
[`ExampleScene`]: #ExampleScene

[`Color`]: https://docs.unity3d.com/ScriptReference/Color.html
[`Gizmos`]: https://docs.unity3d.com/ScriptReference/Gizmos.html
[`Collision`]: https://docs.unity3d.com/ScriptReference/Collision.html
[`Object.Destroy`]: https://docs.unity3d.com/ScriptReference/Object.Destroy.html
[`MonoBehaviour.OnDrawGizmosSelected()`]: https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnDrawGizmosSelected.html
[`Input.GetKey`]: https://docs.unity3d.com/ScriptReference/Input.GetKey.html
[`Object.Instantiate`]: https://docs.unity3d.com/ScriptReference/Object.Instantiate.html
[`GameObject`]: https://docs.unity3d.com/ScriptReference/GameObject.html
[`Rigidbody`]: https://docs.unity3d.com/ScriptReference/Rigidbody.html
