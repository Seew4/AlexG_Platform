using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringTrigger : MonoBehaviour
{

    public Animator playAnimation;
    private Rigidbody2D rbody;
    public float flingHeight;

    // Use this for initialization
    void Start()
    {
        playAnimation = GetComponent<Animator>();
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        playAnimation.SetTrigger("SpringAnim");
        collision.rigidbody.velocity = new Vector3(rbody.velocity.x, flingHeight, 0f);

    }


}
