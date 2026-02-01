using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private bool timerRunning = true;
    private float timeElapsed;

    public float startTime = 30f;
    public TextMeshProUGUI timerText;

    void Start()
    {
        timeElapsed = startTime;
        timerText.text = "Time: " + Mathf.CeilToInt(timeElapsed).ToString();
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
            }

            int secondsElapsed = Mathf.CeilToInt(timeElapsed);
            timerText.text = "Time: " + secondsElapsed.ToString();
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
