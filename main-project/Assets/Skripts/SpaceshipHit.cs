using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipHit : MonoBehaviour {

    public GameObject FeedbackBeiGetroffen;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Enemy"))
        {
            GameControlScript.health -= 1;
            FeedbackBeiGetroffen.gameObject.SetActive(true);
        }
    }
}
