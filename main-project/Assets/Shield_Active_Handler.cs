using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield_Active_Handler : MonoBehaviour {

  public static bool active;

    // Use this for initialization
    void Start()
    {

    }
	
	// Update is called once per frame
	void Update () {

  //funktioniert noch nicht, keine Ahnung warum
        if (active == true)
        {
            this.gameObject.SetActive(true);
        }
        else if (active == false)
        {
            this.gameObject.SetActive(false);
        }
    }
}
