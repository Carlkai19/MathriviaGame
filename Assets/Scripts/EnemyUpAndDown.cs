using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUpAndDown : MonoBehaviour
{
    public float speed = 5f;
    private bool movingUp = false; // Start moving left

    void Update()
    {
        // Move in the current direction
        Vector2 moveDirection = movingUp ? Vector2.up : Vector2.down;
        transform.Translate(moveDirection * speed * Time.deltaTime);
    }

    // OnCollisionEnter2D is called when this collider/rigidbody has begun touching another rigidbody/collider
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the object collided with has a specific tag, e.g., "Wall"
        // You can remove the tag check if you want the enemy to change direction on any collision
        if (collision.gameObject.CompareTag("Wall"))
        {
            movingUp = !movingUp; // Change direction
        }
    }
}
