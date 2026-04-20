using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    //int counter = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public DoorOpen myDoorOpen;
    bool hasPressed=false;
   public AudioSource audioSource;

   public AudioClip buttonPress;
    //public AudioClip unpress;

    void Start()
    {
        
    }
   // private void OnCollisionStay2D(Collision2D collision){
       // if(collision.transform.name == "Player" ){
            //transform.Translate(0, -0.005f, 0);
            
           // GetComponent<SpriteRenderer>().color = Color.green;
           
            
       // }
    //}
     private void OnCollisionEnter2D(Collision2D collision){
        //Checks if the player has stepped on the button if so it turns green.
        if(hasPressed==false) {
        if(collision.transform.name == "Player"){
       
        GetComponent<SpriteRenderer>().color = Color.green;
         audioSource.clip = buttonPress;
         audioSource.Play();
           // counter = counter + 1;
           //Once the button turns green a counter goes up. Once counter reaches number to whatever is assigned in the script inspecter door will open
        myDoorOpen.addCount(1);
        hasPressed=true;
        }

        }
       
    }

    // Update is called once per frame
    void Update()
    {
        //if(counter == 3){
            
        //}
        
    }
}
