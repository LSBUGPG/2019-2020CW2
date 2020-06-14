# Rotation Documentation

This documentation explains how this component works and how it allows the player to click on an object and manipulate it's rotation in real time.

## Behaviours
- ['OnMouseDrag()']

## OnMouseDrag()

This function demonstrates that ['OnMouseDrag'] uses ['Input.GetAxis'] to figure out what axis I wanted to manipulate and ['transform.Rotate'] to do the rotation in the direction that is intended which is is for it to rotate clockwise and counter clockwise. ['Input.GetAxis'] is put into a private float varriable along with another private float value that controls the speed I can rotate the object and it is named ['YAxisRotation'].

**Intended Use**
To allow the player to click on the cube and drag it up or down to rotate it clockwise or counter clockwise based on ['Input.GetAxis'] for up and down input and ['transform.Rotate'] for that rotation.

## Example Scene(s)

In the `ExampleScene` folder contains the examplescene that was set up utlizing the behaviours in this package.

- [`ExampleScene`]

### ExampleScene

This example demonstrates the use of behaviours in this package. For the one behaviour used, it allows the play to click on the object directly and manipulate its axis of rotation.

The ball's state of motion is dependant on whether the player rotates the square or not.


['OnMouseDrag()']: #OnMouseDrag()
[`ExampleScene`]: #ExampleScene

['Input.GetAxis']: https://docs.unity3d.com/ScriptReference/Input.GetAxis.html
['transform.Rotate']: https://docs.unity3d.com/ScriptReference/Input.GetAxis.html


