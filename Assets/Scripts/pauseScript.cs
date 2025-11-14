using UnityEngine;

public class pauseScript : MonoBehaviour {
    public GameObject pauseText;
    bool isPaused;
    public AudioSource audioSource;
    public AudioSource playerAudioSource;
    
    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            isPaused = !isPaused;
        }

        if (isPaused) {
            pauseText.SetActive(true);
            Time.timeScale = 0;
            if (Input.GetKeyDown(KeyCode.Backspace)) {
                UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
            }
            audioSource.Pause();
            playerAudioSource.Pause();
        } else {
            pauseText.SetActive(false);
            Time.timeScale = 1;
            audioSource.UnPause();
            playerAudioSource.UnPause();
        }
    }
}
