using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    float movespeed = 15f;
    private bool schiessen = false;

    public GameObject raketenPrefab;
    public Transform raketenSpawnPoint;
    public float raketenSpeed = 300f;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update()
    {
        //neue Bewegung in FixedUpdate

        //transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * movespeed,
        //                    Input.GetAxis("Vertical") * Time.deltaTime * movespeed,
        //                    0f);

        if (Input.GetButtonDown("Fire1") && !schiessen)
        {
            schiessen = true;
        }
    }

    void FixedUpdate()
    {
        if(schiessen)
        {
            GameObject Rakete = (GameObject) Instantiate(raketenPrefab, raketenSpawnPoint.position, Quaternion.identity);
            Rakete.GetComponent<Rigidbody2D>().AddForce(Vector3.up * raketenSpeed);

            schiessen = false;
        }

        // neue Bewegung, dass Box Collider gut aussieht
        var rigidBody = gameObject.GetComponent<Rigidbody2D>();
        rigidBody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * movespeed, Input.GetAxisRaw("Vertical") * movespeed);
    }
}
