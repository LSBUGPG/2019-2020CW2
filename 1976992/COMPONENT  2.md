# **COMPONENT 2 - Camera Movement**

## Set the camera:

We probably have it already as once you run Unity a camera will be one of the few things that appear on the scene.

## Attach camera to the player:

What we are going to do next is to attach the camera to the player (create one if you don't have it already) so is constantly following it. To do so we are going to create a few variables:

``` C#
    public Vector 3 offset;

    public GameObject player;
```

After this we are reade to set up the code as we need to add to the following lines:

``` C#
    void Start ()
    {
        offset = transform.position - player.transform.position;
    }

    void LateUpdate ()
    {
        transform.position = player.transform.position + offset;
        transform.LookAt(player.transform.position + Vector3.forward * lookAhead);
    }
```

Doing this, the camera will always follow the lead of the character.

## Animation

Secondly, we will also add an animation to the camera that will play once the player has, on this chase, 6 collectables, the ones mention on the first component.

To do so we need to create that animation, at the inside animator in Unity.

Once you've created your animation, the following code:

``` C#
    public Animator anim;

    public float lookAhead;

    public void CameraAnimation()
    {
        anim.enabled = true;
        anim.Play("CameraAnimation");
        lookAhead = 2.5f;
    }
```
Also important to switch the animation off at start as we want it to be active once we've completed the requirements.

``` C#
    void Start ()
    {
        offset = transform.position - player.transform.position;
        anim.enabled = false;
    }
```
To active this animation we need to come back to the `PlayerController` script and add the next lines:

``` C#
    public CameraController camScript;

    void Update ()
    {
        if (count >=6)
        {
            camScript.CameraAnimation();        
        }
    }
```

After this we would be able to connect both scripts and the animation will play after collection, as I said before, the 6 collectables, obviously this can be chamge to any number.

On the next component I will explained the reasson why this camera moves and what other objects interact with this animation.