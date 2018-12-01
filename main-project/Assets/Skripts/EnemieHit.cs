using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieHit : MonoBehaviour {

    public GameObject destruction1;
    public GameObject destruction2;

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
            Destroy(col.gameObject);
            Destroy(gameObject);
            Instantiate(destruction1, transform.position, Quaternion.identity);
            Instantiate(destruction2, transform.position, Quaternion.identity);
        }
    }
}
