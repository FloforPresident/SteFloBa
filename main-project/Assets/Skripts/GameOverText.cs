using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameOverText : MonoBehaviour {


    public Text gameOver;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(ScoreScript.Score < 5000)
        {
            gameOver.text = "oh man bist du scheiße";
        }
        else
        {
        gameOver.text = "GAME OVER \nDein Score: " + ScoreScript.Score;
        }
	}
}
