using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WifiScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    Vector3 scaleTransform = new Vector3(0.05f, 0.05f, 0);
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(0, 1, 0);
        transform.localScale += scaleTransform;
	}
}
