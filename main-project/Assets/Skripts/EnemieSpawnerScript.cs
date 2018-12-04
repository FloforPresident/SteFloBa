using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieSpawnerScript : MonoBehaviour {

    public GameObject enemy;

    public GameObject EndBoss1;
    public static bool endboss = false;

    float randX;
    Vector2 whereToSpawn;
    Vector2 whereToSpawnEndboss1 = new Vector2(0,(float)5.5);

    public static double spawnRate = 2;
    double nextSpawn = 0.0;
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(endboss)
        {
            Instantiate(EndBoss1, whereToSpawnEndboss1, Quaternion.identity);
            EndBoss1.transform.Rotate(new Vector3(0, 0, 1), 180);
            endboss = false;
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
