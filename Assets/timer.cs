using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public static float Timee =0.0f;
    public Text text_Timer;
    

    // Update is called once per frame
    void Update()
    {
        Timee += Time.deltaTime;
        text_Timer.text = "Time : " + Mathf.Round(Timee);
    }

   

}
