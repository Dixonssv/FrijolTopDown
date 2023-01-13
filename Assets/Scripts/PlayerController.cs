using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;

    Vector3 lookPoint;

    public float speed = 5.0f;

    public Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        // Initialize the looking direction to the front
        lookPoint = Vector3.forward;
    }
    void Update()
    {
        lookPoint.x = Input.GetAxisRaw("Horizontal");

        lookPoint.z = Input.GetAxisRaw("Vertical");

        transform.LookAt(transform.position + lookPoint);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + lookPoint * speed * Time.fixedDeltaTime);
    }
}
