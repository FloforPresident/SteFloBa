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
    public static uint Score = 1u;

    public bool extraAmmo1 = true;  //bool damit Ammo nur einmal erhöht wird
    public bool extraAmmo2 = true;
    public bool extraAmmo3 = true;

    // Update is called once per frame
    void Update ()
    {
        if (Score > 100000 && extraAmmo1)
        {
            NewBehaviourScript.counterLaser += 100;
            extraAmmo1 = false;
        }
        if (Score > 200000 && extraAmmo2)
        {
            NewBehaviourScript.counterLaser += 100;     //extra Laser Ammunition
            extraAmmo2 = false;
        }
        if (Score > 300000 && extraAmmo3)
        {
            NewBehaviourScript.counterLaser += 100;
            extraAmmo3 = false;
        }

        if (GameOver == false)
        {
        deltaScore++;
        Score++;    //Gegner zerstören Bonus im EnemieHit script, für Geschosse im 
        }
        score.text = "Score: " + Mathf.Round(Score) /* + " " + EnemieSpawnerScript.spawnRate */;

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
