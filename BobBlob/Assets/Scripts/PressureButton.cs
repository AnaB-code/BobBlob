using UnityEngine;

public class PressureButton : MonoBehaviour
{
    public Vector3 ogPos;
    bool returnPos = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ogPos = transform.position;
        
    }
    private void OnCollisionStay2D(Collision2D collision){
        if(collision.transform.name == "Box" || collision.transform.name == "Player" ){
            transform.Translate(0, -0.005f, 0);
            returnPos = false;
            
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.transform.name == "Box" || collision.transform.name == "Player"){
        collision.transform.parent = transform;
        GetComponent<SpriteRenderer>().color = Color.green;
        }
       
    }
      private void OnCollisionExit2D(Collision2D collision){
    if(collision.transform.name == "Player" || collision.transform.name == "Box"){
        returnPos = true;
        collision.transform.parent = null;
        GetComponent<SpriteRenderer>().color = Color.white;
    }

    }

    
  

    // Update is called once per frame
    void Update()
    {
        if(returnPos == true){
            if(transform.position.y < ogPos.y){
                transform.Translate(0, 0.01f, 0);
                
            }
            else{
                returnPos = false;
            }
        }
    }
}
