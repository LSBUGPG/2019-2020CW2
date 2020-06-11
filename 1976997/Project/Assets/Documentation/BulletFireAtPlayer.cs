//////// Enemy Firing Bullet At Player

//////// In order to explain this code, these are 2 different scripts to describe: Enemy, and bulletScript.

//////Enemy:

//////First, let's describe the enemy script.

//////Here is the first line:

//////    //[SerializeField] GameObject bullet;

//////    All this line does is call an array, which in this case will be the game object "Bullet" shown in Unity. This bullet is also a prefab,
//////        as we are using the same object multiple times.

//////        float fireRate;

//////float nextFire;

//////All these next lines do is give a variable to the fire rate (aka how long it takes for a bullet to spawn), and next Fire (aka the function used
//////to actually fire the next bullet)

//////    fireRate = 2.5f;
//////        nextFire = Time.time;

//////    These lines prove the point above; the fire rate is 2.5 seconds long, which means that it will take 2.5 seconds to fire a bullet at a time.
//////    Time.time is the amount of time in seconds that the application has been running for, which is what the nextFire function is equal to.

//////            void CheckIfTimeToFire()
//////    {
//////    if (Time.time > nextFire)
//////    {
//////        Instantiate(bullet, transform.position, Quaternion.identity);
//////        nextFire = Time.time + fireRate;
//////    }
//////}

//////This if statement essentially meand that if the amount of time that the function has been running for is greater than the time it takes to fire the next bullet,
//////a new bullet will spawn and fire. The final line states that the next bullet will fire after 2.5 seconds due to the fireRate being set to 2.5f.

//        // bulletScript:

//        Finally, let's look at the bulletScript script.

//            GameObject player;
//Rigidbody2D rb;
//public float moveSpeed = 5f;

//The first lines are easy to understand: it gives a variable to the player, the RigidBody created in Unity and the speed of the bullet.

//    player = GameObject.FindGameObjectWithTag("Player");

//    Inside the Start function, it is much easier to understand! it merely states that the player variable equals any game object with the tag "Player."
//Easy!

//     transform.position = Vector2.MoveTowards(transform.position, player.transform.position, moveSpeed* Time.deltaTime);

//    This next line looks complicated, but it is still simple: it basically means that the bullet will move towards the player in accordance with wherever the
//    player is (essentially a homing bullet, following the player at all times) and at a certain speed (which in this instance is 5f).

// if(collision.tag == ("Player"))
//        {
//            Destroy(this.gameObject);
//        }

//The final if statement only means if the bullet collides with the player, then the bullet is destroyed.