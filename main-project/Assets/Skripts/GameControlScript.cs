using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameControlScript : MonoBehaviour {

    public GameObject heart1, heart2, heart3, gameOver;
    public static int health;
    
    // Use this for initialization
	void Start () {
        health = 3;
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
        gameOver.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (health > 3)
            health = 3;
        else if (health < 0)
            health = 0;

        switch (health)
        {
            case 3:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                break;
            case 2:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                break;
            case 1:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                break;
            case 0:
                //StreamReader highscore = new StreamReader(@"\Highscore.txt"); //StreamReader and Writer for Highscore
                //int _highscore = System.Convert.ToInt32(highscore.ReadLine());
                //highscore.Close();

                //if(_highscore < ScoreScript.Score)
                //{
                //StreamWriter sw = new StreamWriter(@"\Highscore.txt");
                //sw.WriteLine(ScoreScript.Score);
                //sw.Close();
                //}

                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                gameOver.gameObject.SetActive(true);
                ScoreScript.GameOver = true;
                Time.timeScale = 0;
                break;

        }
	}
}
