using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float jumpForce = 20.0f; // Adjust the jump force as needed.
    public float maxJumpTime = 0.5f; // Maximum time the player can hold the jump button.
    public float baseJump = 20.0f;

    private Rigidbody2D rb;
    private bool isJumping = false;
    private float jumpTime = 0.0f;

    // Adjust this value to specify the length of the ground check ray.
    public float groundCheckDistance = 0.1f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Check if the player is grounded.
        bool isGrounded = IsGrounded();

        // Check for jump input.
        if (Input.GetButtonDown("Jump") && isGrounded && !isJumping)
        {
            isJumping = true;
            jumpTime = 0.0f;
        }
        else if (Input.GetButton("Jump") && isJumping)
        {
            // Continuously increase jumpTime while the jump button is held.
            jumpTime += Time.deltaTime;

            // Limit the jump time to the maximum allowed time.
            jumpTime = Mathf.Clamp(jumpTime, 0.0f, maxJumpTime);
        }
        else if (Input.GetButtonUp("Jump") && isJumping)
        {
            // Check if the player's velocity on the X-axis is nearly zero.
            if (Mathf.Abs(rb.velocity.x) < 0.1f)
            {
                // Calculate the jump direction as a combination of up and right.
                Vector2 jumpDirection = new Vector2(jumpForce * jumpTime + baseJump, jumpForce * jumpTime + baseJump);

                // Apply the jump force to the rigidbody.
                rb.velocity = jumpDirection;
            }

            isJumping = false;
        }
    }

    // Ground check function using raycasting.
    bool IsGrounded()
    {
        // Cast a ray from the player's position downward.
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, groundCheckDistance);

        // If the ray hits something, the player is grounded.
        return hit.collider != null;
    }
}
