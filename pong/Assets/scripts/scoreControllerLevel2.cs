using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scoreControllerLevel2 : MonoBehaviour
{
    //two variables are assigned for both scores
    public static int player1Score2;
    public static int player2Score2;

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
            player1Score2++;

        }
        //else if the ball goes on -7.55 on the x axis
        else if (ball.transform.position.x <= -7.55f)
        {
            //player 2 score is added by one
            player2Score2++;

        }

        //the scores are converted to strings and put into the score text
        score.text = player1Score2.ToString() + " - " + player2Score2.ToString();

        //if statement for score reaching 10 
        if (player1Score2 == 10 || player2Score2 == 10)
        {
            //level 3 will load
            SceneManager.LoadScene("level3");
        }
    }

}
