using UnityEngine;
using UnityEngine.SceneManagement;

public class DieAndRespawnn : MonoBehaviour {
    public GameObject player; //var for player
    public GameObject respawnPoint; //var for respawn point, seperate empty object
    public bool willReloadScene;

    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Player")) {//checks if what hits it is the player
            player.GetComponent<PlayerMove>().AnimTriggerer("deathState");
            player.GetComponent<DeathCheck>().myKiller = this.gameObject;
            player.GetComponent<PlayerMove>().Slam();
            player.GetComponent<PlayerMove>().isDead = true;

            if (willReloadScene) {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            //Murder();
        }
    }
    public void Murder() {
        if (willReloadScene) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        player.transform.position = respawnPoint.transform.position; //puts player at respawn point
        player.SetActive(false); //disables player (is tempoary) 
    }
}