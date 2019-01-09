using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NewBehaviourScript : MonoBehaviour {

    float movespeed = 5f;
    private bool schiessen1 = false;    //blaue raketen
    private bool schiessen2 = false;    //wifi
    private bool schiessen3 = false;    //laser

    static public int counterWifi = 1;
    static public int counterRaketen = 5;
    static public int counterLaser = 50;


    public GameObject raketenPrefab;
    public GameObject wifiPrefab;
    public GameObject laserPrefab;

    public Transform raketenSpawnPoint;
    public float raketenSpeed = 300f;
    public float wifiSpeed = 1;

    public static int timerWifi = 0;
    public static int timerMissiles = 0;
    public static int timerLaser = 0;
    public const int timerIntervallWifi = 800; //Aufladerate von Missiles & Wifi
    public const int timerIntervallMissiles = 500;
    public const int timerIntervallLaser = 30;

    public static float waitingTime = 0;
    public static float WeapondeltaTime = 1f; //waitingtime between shots

    public static float waitingTimeLaser = 0;
    public static float WeapondeltaTimeLaser = 0.1f; //waitingtime between LaserShots

    //Vector3 scaleTransform = new Vector3(0.1f, 0.1f, 0);

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update()
    {
        timerLaser++;
        if (timerLaser == timerIntervallLaser)
        {
            counterLaser++;
            timerLaser = 0;
        }

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
        if(Input.GetButtonDown("Cancel"))
        {
            Application.Quit();
        }

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
            if (schiessen3)
                schiessen3 = false;
            else
            {
                schiessen3 = true;
            }
        }
    }

    void FixedUpdate()
    {
        if(schiessen2) //Raketen
        {
            if(counterRaketen > 0 && Time.time > waitingTime)
            {
                GameObject Rakete = (GameObject) Instantiate(raketenPrefab, raketenSpawnPoint.position, Quaternion.identity);
                counterRaketen--;
                waitingTime = Time.time + WeapondeltaTime;
            }
            //else    //shoots Laser instead
            //{
            //    GameObject Laser = (GameObject)Instantiate(laserPrefab, raketenSpawnPoint.position, Quaternion.identity);
            //    Laser.GetComponent<Rigidbody2D>().AddForce(Vector3.up * raketenSpeed);
            //}
            schiessen2 = false;
        }

        if (schiessen1) //Wifi
        {
            if (counterWifi > 0 && Time.time > waitingTime)
            {
                GameObject Wifi = (GameObject)Instantiate(wifiPrefab, raketenSpawnPoint.position, Quaternion.identity);
                counterWifi--;
                waitingTime = Time.time + WeapondeltaTime;
            }
            //else    //shoots Laser instead
            //{
            //    GameObject Laser = (GameObject)Instantiate(laserPrefab, raketenSpawnPoint.position, Quaternion.identity);
            //    Laser.GetComponent<Rigidbody2D>().AddForce(Vector3.up * raketenSpeed);
            //}
            schiessen1 = false;
        }

        if (schiessen3) //Laser
        {
            if (counterLaser > 0 && Time.time > waitingTimeLaser)
            {
                GameObject Laser = (GameObject)Instantiate(laserPrefab, raketenSpawnPoint.position, Quaternion.identity);
                Laser.GetComponent<Rigidbody2D>().AddForce(Vector3.up * raketenSpeed);
                counterLaser--;
                waitingTimeLaser = Time.time + WeapondeltaTimeLaser;
            }            
        }

        // neue Bewegung, dass Box Collider gut aussieht
        var rigidBody = gameObject.GetComponent<Rigidbody2D>();
        rigidBody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * movespeed, Input.GetAxisRaw("Vertical") * movespeed);
    }
}
