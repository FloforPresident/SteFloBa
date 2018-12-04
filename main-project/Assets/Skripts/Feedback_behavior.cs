using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feedback_behavior : MonoBehaviour
{

    int framecounter = 0;
    // Use this for initialization
    void Start()
    {
        this.gameObject.SetActive(false);       //default-mäßig false, wird von SpaceshipHit Skript bei Treffer auf true gesetzt
    }

    // Update is called once per frame
    void Update()
    {
        framecounter++;     //frames zählen

        if (framecounter == 15)         //Nach 15 Frames wird das Feedback wieder auf inactive gesetzt
        {
            this.gameObject.SetActive(false);
            framecounter = 0;
        }
    }
}


