using System.Diagnostics;
using UnityEngine;
using UnityEngine.Video;

public class EndVideo : MonoBehaviour
{
    public GameObject cutsceneBackground;
    VideoPlayer vp;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        vp = GetComponent<VideoPlayer>();
        vp.loopPointReached += OnLoopPointReached;
        Physics2D.simulationMode = SimulationMode2D.Script;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnLoopPointReached(VideoPlayer vp)
    {
        // print("video done");
        Physics2D.simulationMode = SimulationMode2D.FixedUpdate;
        cutsceneBackground.SetActive(false);
        this.gameObject.SetActive(false);
    }
}
