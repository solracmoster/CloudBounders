using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {
    float timeLeft = 3.0f;

    public Text Countdown;



    void Update()
    {
        timeLeft -= Time.deltaTime;
        Countdown.text = "" + Mathf.Round(timeLeft);
        
    }
    
}
