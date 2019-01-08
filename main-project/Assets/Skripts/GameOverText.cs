using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;

public class GameOverText : MonoBehaviour {


    public Text gameOver;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //if(ScoreScript.Score < 5000)
        //{
        //    gameOver.text = "oh man bist du scheiße";
        //}
        //else
        {
            StreamReader sr = new StreamReader(@"Highscore.txt");
            string Highscore = sr.ReadLine();
            sr.Close();

        gameOver.text = "GAME OVER \nDein Score: " + ScoreScript.Score + "\n\nHighscore: " + Highscore + "\n\n\nPress ESC to quit";
        }
	}
}
