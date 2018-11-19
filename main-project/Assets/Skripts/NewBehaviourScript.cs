using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    float movespeed = 15f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * movespeed,
                            Input.GetAxis("Vertical") * Time.deltaTime * movespeed,
                            0f);
    }
}
