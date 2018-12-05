using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreScript : MonoBehaviour {

    // Use this for initialization
    void Start() { }
	
    public uint enemy2Points = 10000u;
    public const uint moreDifficult = 10000u;

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
        deltaScore++;
        Score++;    //Gegner zerstören Bonus im EnemieHit script, für Geschosse im 
        score.text = "Score: " + Score + ", " + EnemieSpawnerScript.spawnRate + ", " + deltaScore;

        //Schwierigkeitsgrad erhöhen
        if (deltaScore > moreDifficult)
        {
            EnemieSpawnerScript.spawnRate *= 0.95;
            deltaScore = 0;
        }
        //enemy2 kommt
        if(Score > enemy2Points)
        {
            EnemieSpawnerScript.enemy2Spawn = true;
            enemy2Points += 10000;
        }
    }
}
