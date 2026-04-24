using UnityEngine;

public class FloorPressureButton : MonoBehaviour
{
    FloorOpen myFloorOpen;
    public AudioSource audioSource;

    public AudioClip buttonPress;
    public AudioClip unpress;
    //bool hasPressed=false;
    //public Vector3 ogPos;
    //bool returnPos = false;
    //public DoorOpen doorUnlock;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       // ogPos = transform.position;
       myFloorOpen = GameObject.FindWithTag("Door").GetComponent<FloorOpen>();
        
    }
   // private void OnCollisionStay2D(Collision2D collision){
       // if(collision.transform.name == "Box" || collision.transform.name == "Player" ){
            //transform.Translate(0, -0.005f, 0);
           // returnPos = false;
            
        //}
        
    //}
    private void OnCollisionEnter2D(Collision2D collision){
       
        if(collision.gameObject.CompareTag("Box") ){
        //collision.transform.parent = transform;
        GetComponent<SpriteRenderer>().color = Color.green;
       
        audioSource.clip = buttonPress;
        audioSource.Play();


        if(myFloorOpen != null)
        {
            myFloorOpen.addCount(1);
        }

        //hasPressed=true;
       // doorUnlock.addCount(1);
        
        }
    }
      private void OnCollisionExit2D(Collision2D collision){
        //if(hasPressed=true){
    if(collision.gameObject.CompareTag("Box")){
        //returnPos = true;
        //collision.transform.parent = null;
        GetComponent<SpriteRenderer>().color = Color.blue;
        audioSource.clip = unpress;
        audioSource.Play();

        if(myFloorOpen != null)
        {
            myFloorOpen.addCount(-1);
        }

        
        //hasPressed = false;
        //}
        }
    }

    
  

    // Update is called once per frame
    void Update()
    {
        //if(returnPos == true){
            //if(transform.position.y < ogPos.y){
               // transform.Translate(0, 0.01f, 0);
                
            //}
            //else{
               // returnPos = false;
            //}
        }
    }

