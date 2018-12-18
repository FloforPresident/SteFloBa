using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public float CountdownValue;     //Hier zeit für Countdown einstellen
    float timeLeft;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        timeLeft = CountdownValue;
        text.text = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (Shield_Active_Handler.active == true)
        {
            timeLeft -= Time.deltaTime;
            text.text = "" + Mathf.Round(timeLeft);
            if (timeLeft < 1)
            {
                text.text = null;
                Shield_Active_Handler.active = false;
                timeLeft = CountdownValue;
            }
        }
    }
}
