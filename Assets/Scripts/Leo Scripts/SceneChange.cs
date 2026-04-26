using UnityEngine;
using UnityEngine.SceneManagement;
using System.Diagnostics;
using System.Runtime.InteropServices;

public class SceneChange : MonoBehaviour {
    //[SerializeField] private string scene;
    public int nextSceneLoad;

    void Start()
    {
        nextSceneLoad = SceneManager.GetActiveScene().buildIndex +1; 
    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            if(SceneManager.GetActiveScene().buildIndex == 26)
            {
                print("WIN");
            }
            else
            {
                 SceneManager.LoadScene(nextSceneLoad);

                if(nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
                {
                    PlayerPrefs.SetInt("levelAt", nextSceneLoad);
                }
            }
           
        }
    }
}
