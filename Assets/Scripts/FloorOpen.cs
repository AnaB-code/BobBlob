using UnityEngine;

public class FloorOpen : MonoBehaviour
{

    public int counter = 0;
    public int maxCount = 3;

    Vector3 myPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myPosition=transform.position;
        print(myPosition);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addCount(int amount) {
        counter=counter+amount;
        if(counter>=maxCount) {
            print("done");
            // do something
           transform.position = myPosition+ new Vector3(0,-2.5f,0);
            gameObject.SetActive(false);

        } else {
            print("not done");
            // do something
            transform.position = myPosition;        }
    }
}
