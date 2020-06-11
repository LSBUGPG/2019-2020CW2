# **COMPONENT 1 - Character Movement and Pick Up**

## Create a New Scene:

This components are inspired by the Unity Tutorial: Roll-a-Ball.
Start by creating a new scene called *Tutorial 1*.
Add a 3D `sphere` named *Player* to the scene.
Create a new *Script* called *PlayerController* that would be attached to the *Player*.

## Coding the Movement:

On the previously created script we are going to create a `public float` called `speed`.

Now that we have our first assets ready, we add the movement to the character:
``` C#
    float moveHorizontal * Input.GetAxis("Horizontal");
    float moveVertical = Input.GetAxis ("Vertical");
    Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
    rb.AddForce (movement * speed);
```

This lines of code are included on the  `void Update ()`. As we nee to call them every time we want the ball to move.

## Pick Up

First of all we need to create the object that we will pick up

For the pick ups we would need to create a `private int` called `count`.

The code needed would be as follows:

``` C#
    private int count;

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag ("Pick Up"))
        {
            other.gameObject.SetActive (false);
            count = count + 1;
        }
    }
```

This count would start going up with each one of the objects taged as "Pick Up" that the player collides with but we won't display it as the count is related to something we will see on another component.

Something simple to start with.