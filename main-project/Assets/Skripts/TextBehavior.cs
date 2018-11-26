using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TextBehavior : MonoBehaviour
{
    public Text Wifi;
    public int wifiMunition;

    // Use this for initialization
    void Start()
    {
    }

	// Update is called once per frame
	void Update ()
    {
        wifiMunition = NewBehaviourScript.counterWifi;
        Wifi.text = Convert.ToString(wifiMunition);
	}
}
