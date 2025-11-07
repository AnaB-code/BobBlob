using UnityEngine;

public class menuButton : MonoBehaviour {
    public string sceneToLoad;

    public void OnClick() {
        Debug.Log("You clicked me! You should be loading " + sceneToLoad);
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneToLoad);
    }

    public void QuitGame() {
        Debug.Log("Bye bye!");
        Application.Quit();
    }
}
