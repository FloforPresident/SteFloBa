using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SpaceshipHit : MonoBehaviour {

    public GameObject FeedbackBeiGetroffen;
    AudioSource Audio;

    void Start()
    {
        Audio = GetComponent<AudioSource>();
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Enemy"))
        {
            GameControlScript.health -= 1;
            Audio.Play();
            FeedbackBeiGetroffen.gameObject.SetActive(true);
        }
    }
}
