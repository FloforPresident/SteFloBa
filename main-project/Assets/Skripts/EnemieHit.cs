using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieHit : MonoBehaviour {

    public GameObject destruction1;
    public GameObject destruction2;

    public uint lifes;

    public Sprite damaged1;
    public Sprite damaged2;

    Vector2 whereToSpawnDropIcon;
    public GameObject DropIcon;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag.Equals("Killbound")) //Gegner töten
        {
            Destroy(gameObject);
        }

        if (col.gameObject.tag.Equals("Bullet"))
        {
            Destroy(col.gameObject);
            Instantiate(destruction2, transform.position, Quaternion.identity); //Explosion wenn getroffen

            if (lifes < 2)
            {
            Destroy(gameObject);
            Instantiate(destruction1, transform.position, Quaternion.identity);
            //Instantiate(destruction2, transform.position, Quaternion.identity);
            ScoreScript.Score += 1000;
            ScoreScript.deltaScore += 1000;
            }
            lifes--;


            //Aussehen ändern bei Treffer
        
            if (lifes == 2)
            {
                this.GetComponent<SpriteRenderer>().sprite = damaged1;
            }
            else if (lifes == 1)
            {
                this.GetComponent<SpriteRenderer>().sprite = damaged2;
            }


            //Drop Icon spawnen an letzter Position

            if (lifes == 0)
            {
                whereToSpawnDropIcon = new Vector2(transform.position.x, transform.position.y);
                Instantiate(DropIcon, whereToSpawnDropIcon, Quaternion.identity);
            }
        }
    }
}
