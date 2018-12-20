using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class LaserTextScript : MonoBehaviour
{
    public Text Laser;
    public int laserAmmo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        laserAmmo = NewBehaviourScript.counterLaser;
        Laser.text = Convert.ToString(laserAmmo);
    }
}
