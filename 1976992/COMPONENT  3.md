# **COMPONENT 3 - Disappearing Objects**

## Old Script:

For the next components we need to use an old scrip we've been using before:

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

And add enw stuff to it:

``` C#
    public GameObject ground;
```

That ground that's mention on the script is an objet we need to create on the scene as the floor were the player would be moving around.

This of course can be use for any kind of objects.

## No more floor:

After seting up this, something else would happed while the camera is doing the movement we created before at the second component, this can also be helpful for other kind of games too.

Once the player collects all six collectables the following line would happen:

``` C#
        if (count >=6)
        {
            ground.SetActive(false);       
        }
```

After that the ´ground´ the object we created before would disappear and the character would fall to the emptiness.

This kind of component is usefull if you want to set up a count of collectables before you open a door or something like that.