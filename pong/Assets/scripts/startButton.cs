using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startButton : MonoBehaviour {

	void Start () {
        //importing button and when it is clicked it will fetch the loadGame function
        GetComponent<Button>().onClick.AddListener(() => loadGame());
	}
	
    //loadGame function
    void loadGame()
    {
        //first level of the game will be loaded
        SceneManager.LoadScene("level1");
    }
}
