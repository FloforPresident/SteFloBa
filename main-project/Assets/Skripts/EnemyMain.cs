﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMain : MonoBehaviour {

    public float speed;
    public float stoppingDistance;
    public float retreatDistance;

    private float timeBtwShots;
    public float starttimeBtwShots;

    public GameObject projectile;
    private Transform player;

    // Use this for initialization
    void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        timeBtwShots = starttimeBtwShots;
	}
	
	// Update is called once per frame
	void Update () {
        if (Vector2.Distance(transform.position, player.position) > stoppingDistance)
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);

        else if(Vector2.Distance(transform.position, player.position) < stoppingDistance && Vector2.Distance(transform.position, player.position) > retreatDistance)
            transform.position = this.transform.position;

        else if(Vector2.Distance(transform.position, player.position) < retreatDistance)
            transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);


        if(timeBtwShots <= 0)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
            timeBtwShots = starttimeBtwShots;
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }
}
