using System.Collections;
using System;
using UnityEngine;
using UnityEngine.UI;

public class obstaclesScript : MonoBehaviour
{
    //importing rigidbody
    Rigidbody2D rbody;
    //importing a game object as ball
    GameObject ball;

    void Start()
    {
        //getting the rigidbody component attached to the obstacles
        rbody = GetComponent<Rigidbody2D>();
        //finding the ball in the project
        ball = GameObject.Find("ball");
    }


    void OnCollisionEnter2D(Collision2D coll)
    {
        //If statement to see if the obstacles hit the top border
        if (coll.transform.gameObject.name == "borerTop")
        {
            //if true the obstacles will then go down along the yaxis at a velocity of 2 
            rbody.velocity = -transform.up * 2f;
        }
        //another if statement to see if the obstacles hit the bottom border
        if (coll.transform.gameObject.name == "borderBottom")
        {
            //if true the obstacles will then go up along the yaxis at a velocity of 19
            rbody.velocity = transform.up * 19f;
        }

        //if statement to see if the obstacles collide with the ball
        if (coll.transform.gameObject.name == "ball")
        {
            //ball gets a velocity of 4 on the x axis and 4 on the y axis
            ball.GetComponent<Rigidbody2D>().velocity = new Vector2(4f, 4f);
        }

    }

}
