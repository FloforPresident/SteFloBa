using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectItem : MonoBehaviour {

    GameObject heart1;
    GameObject heart2;
    GameObject heart3;

    // Use this for initialization
    void Start () {

    heart1 = GameObject.Find("/Hearts/fullheart1");
    heart2 = GameObject.Find("/Hearts/fullheart1");
    heart3 = GameObject.Find("/Hearts/fullheart1");

	}
	
	// Update is called once per frame
	void Update () {

        }
        
  void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag.Equals("Player"))
        {
            this.gameObject.SetActive(false);
            if (heart3.activeInHierarchy == false)
            {
                if (heart2.activeInHierarchy == false)
                {
                    heart2.SetActive(true);
                }
                else
                {
                    heart3.SetActive(true);
                }
            }
        }    
    }
}
