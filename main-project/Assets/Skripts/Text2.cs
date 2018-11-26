using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class Text2 : MonoBehaviour
{
    public Text Rakete;
    public int raketenMunition;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        raketenMunition = NewBehaviourScript.counterRaketen;
        Rakete.text = Convert.ToString(raketenMunition);
    }
}
