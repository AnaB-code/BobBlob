using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private bool timerRunning = true;
<<<<<<< Updated upstream
    private float timeElapsed;

    public float startTime = 30f;
    public TextMeshProUGUI timerText;
=======
    public float timeElapsed;

    public float startTime = 10f;
    //public TimedDoor myDoorOpen;
    //public TextMeshProUGUI timerText;
>>>>>>> Stashed changes

    void Start()
    {
        timeElapsed = startTime;
<<<<<<< Updated upstream
        timerText.text = "Time: " + Mathf.CeilToInt(timeElapsed).ToString();
=======
        //timerText.text = "Time: " + Mathf.CeilToInt(timeElapsed).ToString();
>>>>>>> Stashed changes
    }

    void Update()
    {
        if (timerRunning)
        {
            timeElapsed -= Time.deltaTime;

            if (timeElapsed <= 0)
            {
                timeElapsed = 0;
                timerRunning = false;
<<<<<<< Updated upstream
            }

            int secondsElapsed = Mathf.CeilToInt(timeElapsed);
            timerText.text = "Time: " + secondsElapsed.ToString();
=======
                //mydoorOpen.addCount(-1);
            }

            int secondsElapsed = Mathf.CeilToInt(timeElapsed);
            //timerText.text = "Time: " + secondsElapsed.ToString();
>>>>>>> Stashed changes
        }
    }

    void StopTimer()
    {
        timerRunning = false;
    }

    void ResetTimer()
    {
        timeElapsed = startTime;
        timerRunning = true;
    }
}
