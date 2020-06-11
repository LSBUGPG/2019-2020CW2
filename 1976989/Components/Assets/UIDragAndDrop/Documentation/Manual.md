# UI Drag and Drop user guide

This document explains the behaviours contained in this package and describes how to use them to drag and drop UI objects into slots and automatically centre them in said slots. It also explains how to get the component to display a message (either "Correct!" or "Incorrect") to show whether the item placed into the slot was the correct item or not.
This particular component determines whether an object is correct or incorrect by its tag, in this case, the object tagged "Blue" is the correct object, any other tag is not correct.


## Behaviours

- ['ItemSlot']
- [`DragDrop`]

## ItemSlot

This behaviour enables the object it is placed on to become the item slot, it also checks whether the correct item is placed on it or not, and shows a message accordingly.
In order for it to work, the scene requires a canvas with an image (the item slot) placed as the child object of that canvas. This script is attached to the 'item slot'.

There is one configurable parameter on this behaviour:

- (Text) Correct

However, you can also adjust the code slightly in the "OnDrop" function section to change the tag of objects which are classed as correct/incorrect when drag and dropped into the item slot.

### (Text) Correct

This parameter holds the text which states whether a correct or incorrect item is drag and dropped into the item slot. The text should be placed as a child object of the canvas. You will need to drag the text in for this component to work, if the item is the correct item, the text will say "Correct!", otherwise it will say "Incorrect!".

### Tags 

Changing the tags within the "eventData.pointerDrag.tag == ("")" and "eventData.pointerDrag.tag != (""))" will allow you to adjust the objects classed as correct/incorrect when drag and dropped into the item slot. Of course for this to work, the objects themselves must have tags on them.

## DragDrop

This is the behaviour which enables the UI objects to be dragged and dropped into the item slot.
For this behaviour to work, another image object (the item that is dragged) should be placed as a child of the item slot required for the "ItemSlot" behaviour, which should be the child of the canvas, also required for the "ItemSlot" behaviour. The object also requires a "Canvas Group" on it.

This behaviour only has one configurable parameter, which is:

- (Canvas) Canvas

### (Canvas) Canvas

You will need to drag the canvas which parents the item slot and item objects into this for the component to work.


