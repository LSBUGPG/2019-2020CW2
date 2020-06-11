using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float movementSpeed = 10;
    public float jumpForce = 15;
    public float groundCheckRadius;
    private float movementInputDirection;
    public float wallCheckDistance;
    public float wallSlidingSpeed;
    public float movementForceInAir;
    public float airDragMultiplier = 0.95f;
    public float wallHopForce;
    public float wallJumpForce;




    private int facingDirection = 1;



    public bool canJump;
    private bool isFacingRight = true;
    public bool isGrounded;
    public bool isTouchingWall;
    public bool isWallSliding;

    public Transform groundCheck;
    public Transform wallCheck;

    public LayerMask whatIsGround;

    public Vector2 wallHopDirection;
    public Vector2 wallJumpDirection;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
   


    }

    // Update is called once per frame
    void Update()
    {

        checkInput();
        checkMovementDirection();
        checkIfCanJump();
        checkIfWallSliding();
       
    }
    private void FixedUpdate()
    {
        applyMovement();
        CheckSurroundings();

    }
  
    private void checkIfWallSliding()
    {
        if (isTouchingWall && !isGrounded && rb.velocity.y < 0)
        {
            isWallSliding = true;

        }
        else
        {
            isWallSliding = false;
        }
    }
    private void CheckSurroundings()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
        isTouchingWall = Physics2D.Raycast(wallCheck.position, transform.right, wallCheckDistance, whatIsGround);
    }
    private void checkIfCanJump()
    {
        if (isGrounded && rb.velocity.y <= 0 || isWallSliding)
        {
            canJump = true;

        }
        else
        {
            canJump = false;
        }
    }
    private void checkMovementDirection()
    {
        if (isFacingRight && movementInputDirection < 0)
        {
            Flip();
        }
        else if (!isFacingRight && movementInputDirection > 0)
        {
            Flip();

        }

    }
    private void Flip()
    {
        if (!isWallSliding)
        {
            facingDirection *= -1;

            isFacingRight = !isFacingRight;
            transform.Rotate(0, 180, 0);
        }

    }
    private void checkInput()
    {
        movementInputDirection = Input.GetAxisRaw("Horizontal");
        if (Input.GetButtonDown("Jump"))
        {
            Jump();

        }
    }
    private void applyMovement()
    {
        if (isGrounded)
        {
            rb.velocity = new Vector2(movementSpeed * movementInputDirection, rb.velocity.y);
        }
        else if (!isGrounded && !isWallSliding && movementInputDirection != 0)
        {
            Vector2 forceToAdd = new Vector2(movementForceInAir * movementInputDirection, 0);
            rb.AddForce(forceToAdd);

            if (Mathf.Abs(rb.velocity.x) > movementSpeed)
            {
                rb.velocity = new Vector2(movementSpeed * movementInputDirection, rb.velocity.y);
            }
        }
        else if (!isGrounded && !isWallSliding && movementInputDirection == 0)
        {
            rb.velocity = new Vector2(rb.velocity.x * airDragMultiplier, rb.velocity.y);

        }

        if (isWallSliding)
        {
            if (rb.velocity.y < -wallSlidingSpeed)
            {
                rb.velocity = new Vector2(rb.velocity.x, -wallSlidingSpeed);
            }
        }
    }
    private void Jump()
    {
        if (canJump && !isWallSliding)

        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
        else if (isWallSliding && movementInputDirection == 0 && canJump)
        {
            isWallSliding = false;
            Vector2 forceToAdd = new Vector2(wallHopForce * wallHopDirection.x * -facingDirection, wallHopForce * wallHopDirection.y);
            rb.AddForce(forceToAdd, ForceMode2D.Impulse);
        }
        else if ((isWallSliding || isTouchingWall) && movementInputDirection != 0 && canJump)
        {
            isWallSliding = false;
            Vector2 forceToAdd = new Vector2(wallJumpForce * wallJumpDirection.x * movementInputDirection, wallJumpForce * wallJumpDirection.y);
            rb.AddForce(forceToAdd, ForceMode2D.Impulse);
        }

    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
        Gizmos.DrawLine(wallCheck.position, new Vector3(wallCheck.position.x + wallCheckDistance, wallCheck.position.y, wallCheck.position.z));
    }
}
