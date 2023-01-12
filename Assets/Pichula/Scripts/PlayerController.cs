using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    // A reference to the rigidbody of the player
    Rigidbody rb;

    // The direction to which the player is facing
    Vector3 lookPoint;

    // The speed of the player movement
    public float speed = 5.0f;

    public Animator animator;

    void Start()
    {
        // Get the rigidbody component from the game object this script is attached to
        rb = GetComponent<Rigidbody>();

        // Initialize the looking direction to the front
        lookPoint = Vector3.forward;
    }

    void Update()
    {
        lookPoint.x = Input.GetAxisRaw("Horizontal");

        lookPoint.z = Input.GetAxisRaw("Vertical");


        // Turn the player to the corresponding direction
        transform.LookAt(transform.position + lookPoint);
    }

    void FixedUpdate()
    {
        // Move the position of the player
        rb.MovePosition(rb.position + lookPoint * speed * Time.fixedDeltaTime);
    }
}
