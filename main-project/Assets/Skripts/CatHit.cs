using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatHit : MonoBehaviour {

    public GameObject destruction;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Bullet"))
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
            ScoreScript.Score += 500; //Score Punkte
            ScoreScript.deltaScore += 500;

            Instantiate(destruction, transform.position, Quaternion.identity);
        }
        if (col.gameObject.tag.Equals("Player"))
        {
            Destroy(gameObject);
            Instantiate(destruction, transform.position, Quaternion.identity);

            //col.gameObject.transform.localScale += new Vector3(0.03f, 0.03f, 0);
        }
    }
}
