using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectLfie_Item : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag.Equals("Player"))
        {
            this.gameObject.SetActive(false);
            GameControlScript.health++;
        }
    }
}
