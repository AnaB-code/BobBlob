
using UnityEngine;

public class DoorOpen : MonoBehaviour
{

    public int counter = 0;
    public int maxCount = 3;
    public AudioSource audioSource;

    public AudioClip open;
    public AudioClip close;
    Vector3 myPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myPosition=transform.position;
        print(myPosition);
        audioSource.clip = close;
        audioSource.Play();
        // DontDestroyOnLoad(gameObject);
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
           transform.position = myPosition+ new Vector3(0,2.5f,0);
            audioSource.clip = open;
            audioSource.Play();
           // gameObject.SetActive(false);
        } else {
            print("not done");
            // do something
            transform.position = myPosition;
        }
    }
}
