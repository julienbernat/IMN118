using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCar : MonoBehaviour
{

    public Rigidbody rb;

    public float Force = 2000f;
    // Update is called once per frame

    void FixedUpdate()
    {

        if (Input.GetKey("w"))
        {
            rb.AddForce(0,0,Force * Time.deltaTime);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-Force * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -Force * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(Force * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("e"))
        {
            rb.AddForce(0, -Force * Time.deltaTime,0);
        }

        if (Input.GetKey("q"))
        {
            rb.AddForce(0,Force * Time.deltaTime, 0);
        }
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Alien")
        {

            Force = 0;
        }

        if (collisionInfo.collider.tag == "Meteor")
        {
            Force = 0;

        }
    }
}

