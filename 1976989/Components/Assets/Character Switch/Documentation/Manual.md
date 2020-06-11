# Character Switching user guide

This document explains the behaviours contained in this package and describes how to use them to allow the user to switch control between 2 or more different characters by pressing just one key.


## Behaviours

- CharacterSwitch 

- characterMovement - used for the example, from the "2D Movement and Wall Jump" component

## CharacterSwitch

This behaviour should be placed on an empty game object called "Character Switch Object". What this behaviour does is that it switches control between 2, or more, characters in an array after the player presses a certain key on the keyboard, in this case, that key is 'Q'.

There is one configurable parameter on this behaviour which is:

- characters (array)

### characters (array)

This array holds the characters in the scene which will be switched between after the 'Q' button is pressed. The first entry in the array should be the character you start with in the game.
For this to work, every character in the array must have the 'characterMovementSwitch' behaviour on them.
To add more characters to switch between, add another character to the array, but ensure that in the start function, you add "characters[n].GetComponent<characterMovement>().enabled = false;" where n is the character number in the array.

## characterMovement

This behaviour is 2D movement, it is not necessary for this behaviour to work and it is the same movement script as used in my '2D Movement and Wall Jump' component, but allows you to see the 'CharacterSwitch' behaviour work in the example.
