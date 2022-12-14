using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour
{
    //Speed of racket
    public float speed = 150;

    void FixedUpdate()
    {
        //get input
        float h = Input.GetAxisRaw("Horizontal");

        //Set velocity (movement direction * speed)
        GetComponent<Rigidbody2D>().velocity = Vector2.right * h * speed;
    }
}
