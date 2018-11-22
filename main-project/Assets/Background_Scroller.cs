﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_Scroller : MonoBehaviour {

    public float speed;
    Vector3 startPos;

	// Use this for initialization
	void Start () {
        startPos = transform.position;	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate((new Vector3(0, -1, 0)) * speed * Time.deltaTime);

        if (transform.position.y < -9.974487)
        {
            transform.position = startPos;
        }
	}
}
