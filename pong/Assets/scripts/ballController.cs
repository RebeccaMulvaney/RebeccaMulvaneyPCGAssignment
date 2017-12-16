using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ballController : MonoBehaviour {

    //Importing the rigidbody of the ball
    private Rigidbody2D rbody;

	void Start ()
    {
        //Gives the ball movement and velocity at the start 
        GetComponent<Rigidbody2D>().velocity = new Vector2(4f, 4f);
	}
	
	
	void Update () 
    {
        //if statements to see if the ball goes over 7.6 in the x axis
        if (this.transform.position.x >= 7.60f)
        {
            //if true the ball is restarted to the middle of the screen
            this.transform.position = new Vector3(0f, 0f, 0f);
        }
        //anther if statment to see if the ball goes over -7.6 in the x axis
        if (this.transform.position.x <= -7.60f)
        {
            //if true the ball is restarted to the middle of the screen
            this.transform.position = new Vector3(0f, 0f, 0f);
        }

	}


}
