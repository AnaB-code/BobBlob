using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour {
    [SerializeField] private string scene;
    
    private void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.CompareTag("Player")){
            SceneManager.LoadScene(scene);
        }
    }
}
