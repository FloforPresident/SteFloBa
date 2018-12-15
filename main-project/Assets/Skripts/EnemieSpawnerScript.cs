using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieSpawnerScript : MonoBehaviour {

    public GameObject enemy;

    public GameObject enemy2;
    public static bool enemy2Spawn = false;

    float randX;
    Vector2 whereToSpawn;

    public static double spawnRate = 4;
    double nextSpawn = 0.0;
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(enemy2Spawn)
        {
            randX = Random.Range(-7.5f, 7.5f);
            whereToSpawn = new Vector2(randX, 6);
            Instantiate(enemy2, whereToSpawn, Quaternion.identity);
            enemy2Spawn = false;
        }

        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-7.5f, 7.5f);           
            whereToSpawn = new Vector2(randX, transform.position.y);
            Instantiate(enemy, whereToSpawn, Quaternion.identity);
        }
	}
}
