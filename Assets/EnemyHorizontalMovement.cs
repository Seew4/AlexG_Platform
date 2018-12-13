using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMovement : MonoBehaviour
{
    //Skapar en variabel moveSpeed som kontrollerar hur snabbt musen (fiendet) rör sig
    public float moveSpeed = 2f;

    //Skapar en variabel isLeft som gör så att musen går åt vänster från början
    public bool isLeft = true;

    //Länkar komponenten RigidBody2D till rbody
    private Rigidbody2D rbody;

    // Use this for initialization

    void Start()
    {
        //Hämtar komponenten RigidBody2D och sätter den till rbodyn som finns på fiendet
        rbody = GetComponent<Rigidbody2D>();

        //Sätter move till false
        Move(false);
    }

    // Update is called once per frame

    private void Move(bool flip)
    {
        //Om flip är true (vilket den inte är) så rör sig musen åt höger, alltså inte vänster
        if (flip == true)
        {
            isLeft = !isLeft;
        }

        //Om musen går åt höger blir den också vänd åt höger
        if (isLeft == true)
        {
            rbody.velocity = new Vector2(-moveSpeed, rbody.velocity.y);
            transform.localScale = new Vector3(1, 1, 1);
        }

        //Om musen inte går åt höger, dvs vänster blir den vänd åt vänster
        else
        {
            rbody.velocity = new Vector2(moveSpeed, rbody.velocity.y);
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }

    //Om musen kolliderar med min "Wall" vänder den
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Wall")
        {
            Move(true);
        }
    }
}
