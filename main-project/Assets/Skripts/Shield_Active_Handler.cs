using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield_Active_Handler : MonoBehaviour {

    public static bool active;
    public GameObject shield;

    //CountDown wurde ausgelagert in Countdown Script

    // Use this for initialization
    void Start()
    {
        shield.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        
        if (active == true)
        {
            shield.SetActive(true);
        }
        else if (active == false)
        {
            shield.SetActive(false);
        }
    }
}
