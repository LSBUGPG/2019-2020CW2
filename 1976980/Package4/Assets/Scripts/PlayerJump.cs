using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private LayerMask platformsLayerMask;
    private Rigidbody2D rigidbody2d;
    private BoxCollider2D boxCollider2d;

    // Update is called once per frame
    private void Awake()
    {
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
        boxCollider2d = transform.GetComponent<BoxCollider2D>();
    }
    private void Update()
    {
        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            float jumpVelocity = 20f;
            rigidbody2d.velocity = Vector2.up * jumpVelocity;
        }
    }

    private bool IsGrounded()
    {
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, .1f, platformsLayerMask);

        return raycastHit2d.collider != null;

    }

}
