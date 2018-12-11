using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    float movespeed = 5f;
    private bool schiessen1 = false;    //blaue raketen
    private bool schiessen2 = false;    //wifi
    private bool schiessen3 = false;    //laser

    static public int counterWifi = 1;
    static public int counterRaketen = 5;

    public GameObject raketenPrefab;
    public GameObject wifiPrefab;
    public GameObject laserPrefab;

    public Transform raketenSpawnPoint;
    public float raketenSpeed = 300f;
    public float wifiSpeed = 1;

    public static int timerWifi = 0;
    public static int timerMissiles = 0;
    public const int timerIntervallWifi = 800; //Aufladerate von Missiles & Wifi
    public const int timerIntervallMissiles = 500;

    public float waitingTime = 0;
    public float WeapondeltaTime = 0.1f; //waitingtime between shots

    //Vector3 scaleTransform = new Vector3(0.1f, 0.1f, 0);

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update()
    {
        timerMissiles++;
        if (timerMissiles == timerIntervallMissiles)
        {
            counterRaketen++;
            timerMissiles = 0;
        }

        timerWifi++;
        if(timerWifi == timerIntervallWifi)
        {
            counterWifi++;
            timerWifi = 0;
        }

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
            if(counterRaketen > 0 && Time.time > waitingTime)
            {
                GameObject Rakete = (GameObject) Instantiate(raketenPrefab, raketenSpawnPoint.position, Quaternion.identity);
                //Rakete.GetComponent<Rigidbody2D>().AddForce(Vector3.up * raketenSpeed);
                counterRaketen--;
                waitingTime = Time.time + WeapondeltaTime;
            }
            schiessen1 = false;
        }

        if (schiessen2) //Wifi
        {
            if (counterWifi > 0 && Time.time > waitingTime)
            {
                GameObject Wifi = (GameObject)Instantiate(wifiPrefab, raketenSpawnPoint.position, Quaternion.identity);
                //Wifi.GetComponent<Rigidbody2D>().AddForce(Vector3.up * wifiSpeed);
                counterWifi--;
                waitingTime = Time.time + WeapondeltaTime;
            }
            schiessen2 = false;
        }

        if (schiessen3) //Laser
        {
            if (Time.time > waitingTime*0.5)
            {
            GameObject Laser = (GameObject)Instantiate(laserPrefab, raketenSpawnPoint.position, Quaternion.identity);
            Laser.GetComponent<Rigidbody2D>().AddForce(Vector3.up * raketenSpeed);
            //waitingTime = Time.time + WeapondeltaTime;
            }
            schiessen3 = false;
        }

        // neue Bewegung, dass Box Collider gut aussieht
        var rigidBody = gameObject.GetComponent<Rigidbody2D>();
        rigidBody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * movespeed, Input.GetAxisRaw("Vertical") * movespeed);
    }
}
