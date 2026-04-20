using UnityEngine;

public class TimedDoor : MonoBehaviour
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
        myPosition = transform.position;
        print(myPosition);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void openDoor()
    {
        transform.position = myPosition + new Vector3(0, 2.5f, 0);
        audioSource.clip = open;
        audioSource.Play();
    }
     public void closeDoor()
    {
        transform.position = myPosition;
        audioSource.clip = close;
        audioSource.Play();
    }
}