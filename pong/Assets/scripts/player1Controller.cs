using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player1Controller : MonoBehaviour {

    //importing the paddle's rigidbody
    private Rigidbody2D rbody;

	
	void Start () {
        //giving the rigidbody a variable name 
        rbody = GetComponent<Rigidbody2D> ();
	}
	
	
	void Update () {
        //giving the velocity of the rigidbody a variable name 
        var velocity = rbody.velocity;

        //an if statement to see if the button W is being pressed
        if(Input.GetKeyDown(KeyCode.W))
        {
            //if true the paddle will go up along the y axis with a velocity of 16;
            velocity.y = 16f;
        }
        //else if statement to see if the button S is being pressed
        else if(Input.GetKeyDown(KeyCode.S))
        {
            //if true the paddle will go down along the y axis with a veloctiy of 16
            velocity.y = -16f;
        }

        //giving the rigidbody's velocity the velocity we used in the if statements
        rbody.velocity = velocity;
	}
}
