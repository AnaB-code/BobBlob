using UnityEngine;

public class menuButton : MonoBehaviour {
    public string sceneToLoad;
    public AudioClip clickSound;
    public AudioSource audioSource;

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
