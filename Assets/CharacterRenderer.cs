using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class CharacterRenderer : MonoBehaviour
{
    BoxCollider collider;

    public SpriteRenderer body;
    public SpriteRenderer frontArm;
    public SpriteRenderer backArm;

    void Start()
    {
        Tilt();

        collider = GetComponent<BoxCollider>();


    }

    
    void Update()
    {
        
    }

    void Tilt()
    {
        transform.rotation = Quaternion.Euler(45, 0, 0);
    }

    [ContextMenu("Flip")]
    void Flip()
    {
        body.flipX = !body.flipX;
        frontArm.flipX = !frontArm.flipX;
        backArm.flipX = !backArm.flipX;
    }
}
