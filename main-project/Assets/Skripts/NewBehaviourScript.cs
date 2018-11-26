using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    float movespeed = 5f;
    private bool schiessen1 = false;    //blaue raketen
    private bool schiessen2 = false;    //wifi
    private bool schiessen3 = false;    //laser

    static public int counterWifi = 10;
    static public int counterRaketen = 20;

    public GameObject raketenPrefab;
    public GameObject wifiPrefab;
    public GameObject laserPrefab;

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

        if (Input.GetButtonDown("Fire1") && !schiessen1)
        {
            schiessen1 = true;
        }
        if (Input.GetButtonDown("Fire2") && !schiessen2)
        {
            schiessen2 = true;
        }
        if (Input.GetButtonDown("Fire3") && !schiessen2)
        {
            schiessen3 = true;
        }
    }

    void FixedUpdate()
    {
        if(schiessen1) //Raketen
        {
            if(counterRaketen > 0)
            {
                GameObject Rakete = (GameObject) Instantiate(raketenPrefab, raketenSpawnPoint.position, Quaternion.identity);
                Rakete.GetComponent<Rigidbody2D>().AddForce(Vector3.up * raketenSpeed);
                counterRaketen--;
            }
            else //keine Munition, Raketen werden verschossen
            {
                GameObject Laser = (GameObject)Instantiate(laserPrefab, raketenSpawnPoint.position, Quaternion.identity);
                Laser.GetComponent<Rigidbody2D>().AddForce(Vector3.up * raketenSpeed);
            }

            schiessen1 = false;
        }

        if (schiessen2) //Wifi
        {
            if (counterWifi > 0)
            {
                GameObject Wifi = (GameObject)Instantiate(wifiPrefab, raketenSpawnPoint.position, Quaternion.identity);
                Wifi.GetComponent<Rigidbody2D>().AddForce(Vector3.up * raketenSpeed);
                counterWifi--;
            }
            else //keine Munition, Raketen werden verschossen
            {
                GameObject Laser = (GameObject)Instantiate(laserPrefab, raketenSpawnPoint.position, Quaternion.identity);
                Laser.GetComponent<Rigidbody2D>().AddForce(Vector3.up * raketenSpeed);
            }
            schiessen2 = false;
        }

        if (schiessen3) //Laser
        {
                GameObject Laser = (GameObject)Instantiate(laserPrefab, raketenSpawnPoint.position, Quaternion.identity);
                Laser.GetComponent<Rigidbody2D>().AddForce(Vector3.up * raketenSpeed);
                
                schiessen3 = false;
        }

        // neue Bewegung, dass Box Collider gut aussieht
        var rigidBody = gameObject.GetComponent<Rigidbody2D>();
        rigidBody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * movespeed, Input.GetAxisRaw("Vertical") * movespeed);
    }
}
