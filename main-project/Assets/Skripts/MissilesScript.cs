using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissilesScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    Vector3 scaleTransform = new Vector3(0.01f, 0.01f, 0);
    // Update is called once per frame
    void Update ()
    {
        transform.Translate(0, 0.2f, 0);
        transform.localScale += scaleTransform;
    }
}
