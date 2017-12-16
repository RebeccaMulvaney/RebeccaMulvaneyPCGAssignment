using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scoreControllerLevel3 : MonoBehaviour
{
    //two variables are assigned for both scores
    public static int player1Score3;
    public static int player2Score3;

    //text score is imported
    public Text score;
    //the ball is imported as a game object 
    public GameObject ball;

    void Start()
    {
        //finding the ball from unity
        ball = GameObject.Find("ball");

    }

    void Update()
    {
        //if the ball goes on 7.55 on the x axis
        if (ball.transform.position.x >= 7.55f)
        {
            //player 1 score is added by one 
            player1Score3++;

        }
        //else if the ball goes on -7.55 on the x axis
        else if (ball.transform.position.x <= -7.55f)
        {
            //player 2 score is added by one
            player2Score3++;

        }
        //the scores are converted to strings and put into the score text
        score.text = player1Score3.ToString() + " - " + player2Score3.ToString();

        //if statement for score reaching 15 
        if (player1Score3 == 15 || player2Score3 == 15)
        {
            //ending score board will load
            SceneManager.LoadScene("endGame");
        }
    }
}
