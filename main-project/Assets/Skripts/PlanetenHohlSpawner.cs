using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlanetenHohlSpawner : MonoBehaviour
{

    public GameObject planet0;
    public GameObject planet1;
    public GameObject planet2;
    public GameObject planet3;
    public GameObject planet4;
    public GameObject planet5;

    GameObject spawnPlanet;

    float randX;
    Vector3 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;
    int counter = 0;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (counter %6 == 0)
        {
            spawnPlanet = planet0;
        }
        else if(counter %6 == 1)
        {
            spawnPlanet = planet1;
        }
        else if (counter % 6 == 2)
        {
            spawnPlanet = planet2;
        }
        else if (counter % 6 == 3)
        {
            spawnPlanet = planet3;
        }
        else if (counter % 6 == 4)
        {
            spawnPlanet = planet4;
        }
        else if (counter % 6 == 5)
        {
            spawnPlanet = planet5;
        }

        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-7.5f, 7.5f);
            whereToSpawn = new Vector3(randX, transform.position.y, 1);
            Instantiate(spawnPlanet, position: whereToSpawn, rotation: Quaternion.identity);
            counter++;
        }
    }
}
