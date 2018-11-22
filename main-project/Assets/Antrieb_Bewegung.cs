using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Antrieb_Bewegung : MonoBehaviour {

    float movespeed = 15f;

    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void Update () {
        //transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * movespeed, Input.GetAxis("Vertical") * Time.deltaTime * movespeed, 0f);
       
    }
    void FixedUpdate()
    {
        var rigidBody = gameObject.GetComponent<Rigidbody2D>();
        rigidBody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * movespeed, Input.GetAxisRaw("Vertical") * movespeed);
    }
}

