//// Double Jump

//This script's purpose is to give the player as many extra jumps as they like, as they can edit the maximum amount of jumps they have
//in Unity. Below is how the code works.

//        public float speed;
//public float jumpForce;
//private float moveInput;

//private Rigidbody2D rb;

//private bool isGrounded;
//public Transform groundCheck;
//public float checkRadius;
//public LayerMask whatIsGround;

//private int extraJumps;
//public int extraJumpsValue;

//Each of the lines listed above create functions for the script. Any public functions can be edited in Unity while private functions can't.

//The first 3 lines get the player to move and jump, as well as how fast they move.

//    The second line creates a function to edit the RigidBody2D component found in Unity.

//    The third set of lines are set up to check whether the player is on the ground when he jumps, for example,
//    the function "whatIsGround" is a new layer that checks if the platforms the player is standing on has a layer called "Ground."

//The final set of lines are functions for the bonus jumps and how many bonus jumps the player is allowed.

//       void Start()
//{
//    extraJumps = extraJumpsValue;
//    rb = GetComponent<Rigidbody2D>();
//}

//void FixedUpdate()
//{
//    isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

//    moveInput = Input.GetAxisRaw("Horizontal");
//    rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
//}

//The functions listed above are the following:

//    The first set (below Start) help the player jump by calling the RigidBody2D component and stating that the value for extra jumps
//    are the amount of bonus jumps the player has.

//    Meanwhile, inside FixedUpdate, the first line sets up a ground check for the player, i.e to double check whether the player
//    is on the groundm and the bottom two lines are the player's controls. Since it is a 2D function, only the horizontal controls (left and right)
//    are needed.

//        void Update()
//    {
//    if (isGrounded == true)
//    {
//        extraJumps = extraJumpsValue;
//    }

//    if (Input.GetKeyDown(KeyCode.Space) && extraJumps > 0)
//    {
//        rb.velocity = Vector2.up * jumpForce;
//        extraJumps--;
//    }

//    else if (Input.GetKeyDown(KeyCode.Space) && extraJumps == 0 && isGrounded == true)
//    {
//        rb.velocity = Vector2.up * jumpForce;
//    }
//}

//This section is long but simple to understand.

    //The first set of lines dictate that if the player is grounded, then the player can start jumping.

    //The second set of lines say that if the space bar is pressed and the extra jumps are greater than 0, then the player jumps, and
        //an extra jump value is decreased each time.

        //Finally, the last set of lines say that if the space bar is pressed, the extra jumps are equal to 0 and the player is grounded, then the player
        //jumps, but has no extra jumps left and can't jump again until they hit the ground.