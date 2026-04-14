using UnityEngine;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine.UI;


public class menuButton : MonoBehaviour {
    public string sceneToLoad;
    public AudioClip clickSound;
    //public VideoClip CutsceneExample;
    public AudioSource audioSource;
    //public VideoSource videoSource;
    //public Button[] buttons;
    //void Start()
    //{
        //int levelAt = PlayerPrefs.GetInt("levelAt", 3);
        
        //for(int i = 0; i < buttons.Length; i++)
        //{
            //if(i + 3 > levelAt)
            //{
                //buttons[i].interactable = false;
            //}
        //}
    //}
    public void OnClick() {
        audioSource.PlayOneShot(clickSound);
        if (sceneToLoad != "") {
            Debug.Log("You clicked me! You should be loading " + sceneToLoad);
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneToLoad);
        } else {
            Debug.Log("No scene has been programmed into this button. Please fix that");
        }
    }

    public void QuitGame() {
        audioSource.PlayOneShot(clickSound);
        Debug.Log("Bye bye!");
        Application.Quit();
    }
}
