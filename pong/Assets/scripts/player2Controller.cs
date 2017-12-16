using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player2Controller : MonoBehaviour {
    //importing the ball as a game object
    GameObject ball;


	void Start () {
        //finding the ball in unity
        ball = GameObject.Find("ball");
	}
	
	
    void Update()
    {
        //Giving the paddle a velocity 
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, Input.GetAxis("Vertical2")) * 80;

        //getting the mouse position 
        Vector3 mousePosition = Input.mousePosition;
        //using the mouse position as the paddle position
        Vector3 paddlePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        //giving the paddle a constricted position of 2 > y < -2.9 along the y axis
        transform.position = new Vector3(7f, Mathf.Clamp(paddlePosition.y, -2.9f, 2f));

    }
}
