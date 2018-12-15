using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setDropIconInactive : MonoBehaviour {


    int framecounter = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        framecounter++;

        if (framecounter == 300)         //Nach 15 Frames wird das Feedback wieder auf inactive gesetzt
        {
            this.gameObject.SetActive(false);
            framecounter = 0;
        }
    }
}
