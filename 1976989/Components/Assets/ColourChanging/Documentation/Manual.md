# Colour Change user guide

This document explains the behaviours contained in this package and describes how to use them to change the colour of objects in a scene once they touch other objects with certain tags. 



## Behaviours

- [`colourChange`]

- characterMovement - used for the example, from the "2D Movement and Wall Jump" component


## colourChange

This behaviour should only need to be placed on the object which changes colour. What this behaviour does is that it gets the sprite renderer of the object it is on, and then it changes the colour of the sprite renderer once the object touches other objects with certain tags.
This means that the colour changes to whatever colour the touched object is.

For this to work properly, it is ideal that the object which will have its colour changed is white to begin with.

There are no configurable parameters on this behaviour, but you can adjust the code slightly in the "OnTriggerEnter2D" section to change the tag of objects which the colour changing object can interact with.


### Tags

Changing the tag within the "other.gameObject.tag == ("")" code in the "OnTriggerEnter2D" section will allow any object with a certain tag to be interacted with, in this case when that object is touched, the object touching it will change into the colour of the tagged object (if you tell it to do so in code (by changing the "rend.color = Color.n" where n is a colour.)).
Of course for this to work, the objects which are to be touched must have tags on them.

## characterMovement

This behaviour is 2D movement, it is not necessary for this behaviour to work and it is the same movement script as used in my '2D Movement and Wall Jump' component, but allows you to see the 'colourChange' behaviour work in the example.
