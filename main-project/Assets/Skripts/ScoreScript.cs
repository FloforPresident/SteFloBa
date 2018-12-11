using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreScript : MonoBehaviour {

    // Use this for initialization
    void Start() { }
	
    public uint enemy2Points = 10000u; //score points to spawn enemy2
    public const uint moreDifficult = 5000u; //reaching this score, game gets harder

    public static bool GameOver = false;
    float enhanceSpawning = (float)0.9;

    public ScoreScript()
    {
        EnemieSpawnerScript.enemy2Spawn = false;
    }

    public Text score;
    public static uint deltaScore = 0u;
    public static uint Score = 0u;
	// Update is called once per frame
	void Update ()
    {
        if(GameOver == false)
        {
        deltaScore++;
        Score++;    //Gegner zerstören Bonus im EnemieHit script, für Geschosse im 
        }
        score.text = "Score: " + Score + " " + EnemieSpawnerScript.spawnRate;

        //Schwierigkeitsgrad erhöhen
        if (deltaScore > moreDifficult)
        {
            if(EnemieSpawnerScript.spawnRate > (float)0.4) //0.5 minimale spawnrate
            {
            EnemieSpawnerScript.spawnRate *= enhanceSpawning;
            deltaScore = 0;
            }
        }
        //enemy2 kommt
        if(Score > enemy2Points)
        {
            EnemieSpawnerScript.enemy2Spawn = true;
            enemy2Points += 10000;
        }
    }
}
