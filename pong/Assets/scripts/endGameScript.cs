using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endGameScript : MonoBehaviour {
    
    //UI texts
    public Text score1;
    public Text score2;
    public Text score3;
    public Text score4;
    public Text score5;
    public Text score6;
    public Text winningPlayer;

    //integers to store the scores in
    int s1;
    int s2;
    int s3;
    int s4;
    int s5;
    int s6;

	void Start () {
        //importing the scores throughout the levels and storing them into integers
        s1 = scoreController.player1Score1; //player 1 level 1
        s2 = scoreController.player2Score1; //player 2 level 1
        s3 = scoreControllerLevel2.player1Score2; //player 1 level 2
        s4 = scoreControllerLevel2.player2Score2; //player 2 level 2
        s5 = scoreControllerLevel3.player1Score3; //player 1 level 3
        s6 = scoreControllerLevel3.player2Score3; //player 2 level 3
	}
	
	void Update () {
        //putting the variables holding the scores into text
        score1.text = s1.ToString(); //player 1 level 1
        score2.text = s2.ToString(); //player 2 level 1 
        score3.text = s3.ToString(); //player 1 level 2
        score4.text = s4.ToString(); //player 2 level 2
        score5.text = s5.ToString(); //player 1 level 3
        score6.text = s6.ToString(); //player 2 level 3

        //adding up all the scores of player 1
        int player1 = s1 + s3 + s5;
        //adding up all the scores of player 2
        int player2 = s2 + s4 + s6;

        //if statement to see if player 1 has a higher score than player 2
        if (player1 > player2)
        {
            //if true text will show player 1 won
            winningPlayer.text = "Player 1";
        }
        //else if statement to see if player 2 has a higher score than player 1
        else if (player2 > player1)
        {
            //if true player 2 will be shown in the text
            winningPlayer.text = "Player 2";
        }
        //another else if statement that if both players get the same amount of scores
        else if (player1 == player2)
        {
            //text will show draw
            winningPlayer.text = "Draw";
        }
	}


}
