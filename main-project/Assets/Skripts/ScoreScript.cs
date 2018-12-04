using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public Text score;
    public static uint Score = 0u;
	// Update is called once per frame
	void Update ()
    {
        Score++;    //Gegner zerstören Bonus im EnemieHit script, für Geschosse im 
        score.text = "Score: " + Score;

        //if(Score > 10000)
        //{
        //    EnemieSpawnerScript.spawnRate *= 5;
        //}
	}
}
