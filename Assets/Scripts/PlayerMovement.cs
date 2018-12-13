using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [Range(0, 20f)]
    public float moveSpeed;
    public float jumpHeight;

    private Rigidbody2D rbody;
    public GroundCheck groundCheck;
    public float MoveSpeed;
    public float UpSpeed;
    public float shiftSpeed;

    // Use this for initialization
    //Länkar komponenten RigidBody2D till rbody
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
       rbody.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, rbody.velocity.y);
        Physics.gravity = new Vector3(0, -120f, 0);



        //När man trycker Space så hoppar man, bara om groundCheck nuddar marken dock
        if (Input.GetKeyDown(KeyCode.Space) && groundCheck.touches > 0)
        {
            rbody.velocity = new Vector2(rbody.velocity.x, jumpHeight);
        }

    }
}


