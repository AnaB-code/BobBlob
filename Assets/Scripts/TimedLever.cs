using UnityEngine;

public class TimedLever : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public TimedDoor myDoorOpen;
    bool hasPressed = false;
    public float startTime = 10f;
    public float timeElapsed;
    public AudioSource audioSource;

    public AudioClip buttonPress;
    public AudioClip unpress;
    void Start()
    {
        timeElapsed = startTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Checks if the player has stepped on the button if so it turns green.
        if (hasPressed == false)
        // Debug.Log("pressed");
        {
            if (collision.transform.name == "Player")
            {
                GetComponent<SpriteRenderer>().color = Color.green;
                myDoorOpen.openDoor();
                 audioSource.clip = buttonPress;
                 audioSource.Play();
                hasPressed = true;
            }

        }
    }

    void Update()
    {
        if (hasPressed == true)
        {
            timeElapsed -= Time.deltaTime;
            if (timeElapsed <= 0)
            {
                timeElapsed = startTime;
                hasPressed = false;
                GetComponent<SpriteRenderer>().color = Color.blue;
                audioSource.clip = unpress;
                audioSource.Play();
                myDoorOpen.closeDoor();
            }

            int secondsElapsed = Mathf.CeilToInt(timeElapsed);
            //timerText.text = "Time: " + secondsElapsed.ToString();
        }
    }


    // if (timeElapsed == 0)
    // {
    //     if (hasPressed == true)
    //     {
    //         if (collision.transform.name == "Player")
    //         {

    //             GetComponent<SpriteRenderer>().color = Color.blue;
    //             // counter = counter + 1;
    //             //Once the button turns green a counter goes up. Once counter reaches number to whatever is assigned in the script inspecter door will open
    //             // myDoorOpen.addCount(-1);
    //             hasPressed = false;
    //         }

    //     }
    // }

    // private void OnCollisionExit2D(Collision2D collision){
    //     if(timeElapsed == 0){
    //     if(hasPressed==true) {
    //     if(collision.transform.name == "Player"){

    //     GetComponent<SpriteRenderer>().color = Color.blue;
    //        // counter = counter + 1;
    //        //Once the button turns green a counter goes up. Once counter reaches number to whatever is assigned in the script inspecter door will open
    //     myDoorOpen.addCount(-1);
    //     hasPressed=false;
    //     }

    //     }
    //     }
    // }

    // Update is called once per frame
    
}

        // if(timeElapsed <= 0){
        //     var = 1;
        // } else {
        //     var = 2;
        // }
        // switch(var){
        //     case 1: 
        //    // hasPressed = false;
        //     timeElapsed = startTime;
        //     timerRunning = false;
        //     break;
        //     case 2: 
        //    // hasPressed = true;
        //     timerRunning = true;
        //     //myDoorOpen.addCount(-1);
        //     if (timerRunning)
        // {
        //     timeElapsed -= Time.deltaTime;

        //     if (timeElapsed <= 0)
        //     {
        //         timeElapsed = 0;
        //         timerRunning = false;

        //     }

        //    int secondsElapsed = Mathf.CeilToInt(timeElapsed);
        //     //timerText.text = "Time: " + secondsElapsed.ToString();
        // }
        // break;

        // }
        //if(counter == 3){

        //}


    // void StopTimer()
    // {
    //     timerRunning = false;
    // }

    // void ResetTimer()
    // {
    //     timeElapsed = startTime;
    //     timerRunning = true;
    // }

