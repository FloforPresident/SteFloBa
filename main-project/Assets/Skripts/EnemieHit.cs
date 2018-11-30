using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieHit : MonoBehaviour {

    public GameObject destruction;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag.Equals("Bullet"))
        {
            Instantiate(destruction, transform.position, Quaternion.identity);
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}
