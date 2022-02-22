using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeValue = 90;
    public Text timeText;
    public GameObject TimerGuard1;
    public GameObject TimerGuard2;
    public GameObject TimerGuard3;
    public GameObject TimerGuard4;



    private void Update()
    {
        if(timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
        }

        displayTime(timeValue);
        
        if(timeValue == 0)
        {
            Debug.Log("game over");
            TimerGuard1.gameObject.SetActive(true);
            TimerGuard2.gameObject.SetActive(true);
            TimerGuard3.gameObject.SetActive(true);
            TimerGuard4.gameObject.SetActive(true);


        }

    }


    void displayTime(float timeToDisplay)
    {
        if(timeToDisplay < 0 )
        {
            timeToDisplay = 0;
        }

        

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0, 00} : {1 : 00}", minutes, seconds);
    }

}