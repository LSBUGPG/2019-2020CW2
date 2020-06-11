# **COMPONENT 4 - Distance Count**

## Scene:

First of all, before we go to the code we are going to create an object, a cube in this chase.

We are goint to a collider to this object and also tagged as `StartCount` and we separate the collider a little from the object so the following code would be active once the player touches the collider.

Rememeber that we also need other `gameObjects` we created in old components as the `player` which is necesary to activate this counter.

We would need to create a text (Text Mesh Pro) so the count can go up. And we would add this to the player later on.

Dont forget to do:

``` C#
    using TMPro;
```

## Code Code Code:

We need to create some variables to start with:

``` C#
    public TextMeshProUGUI countText;
    public GameObject distanceMarker;
    public float distance;
    bool startDistanceCount;
```

The `distanceMarker` is going to be the object we created before where the distance would start counting, this point can be were the player starts.

``` C#
    void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "StartCount")
            startDistanceCount = !startDistanceCount;
    }
```

Here we are activating the distance count once the `player` collides with this object.

``` C#
    void Update()
    {
        distance = Vector3.Distance(player.transform.position, distanceMarker.transform.position);

        if(startDistanceCount)
            setCountText ();
    }

    void setCountText ()
    {
        countText.text = "Distance: " + distance.ToString ("F0");
    }
```

All this would calculates the distance between the point previously created (`distanceMarker`) and the `player`