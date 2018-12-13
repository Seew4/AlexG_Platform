using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fling : MonoBehaviour
{

    public float bounciness;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            player.GetComponent<Rigidbody2D>().AddForce(Vector2.up, ForceMode2D.Force);


        }
    }
}