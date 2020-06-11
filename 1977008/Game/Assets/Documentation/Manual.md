# First Person Controller

This document explains the behaviours contained in this package and describes how to use them to create a health bar appear above a objects head.

## Behaviours

- [`BillBoard`]
- [`HealthBar`]
- [`Player`]
- [`PlayerMovement`]
- [`Rotator`]


## BillBoard

This behaviour should be applied to which ever camera will be used as the player's perspective. 

The behaviour responds to the `LookAt` method which makes a object always look towards the camera.

It has the following configurable parameter:

- Camera

### Camera

This allows the user to choose which camera they use.

## HealthBar

This behaviour should be applied to whatever the player object is meant to be. The behaviour responds to the `Slider` method which takes the value of a slider as the health. 

## Player

This behaviour should be applied to whatever the player object is meant to be. 
It has the following configurable parameters:

- Max Health

### Max Health

This allows the players maximum health to be modified.

## PlayerMovement

This behaviour should be applied to whatever the player object is meant to be. The behaviour responds to the `Move` method which takes a direction to move as input. 
It has the following configurable parameters:

- speed

### Speed

This allows the user to adjust the speed of which the moves around.

## Rotator

It has the following configurable parameters:

### Speed

This allows the user to adjust the speed of which the camera rotates ingame.