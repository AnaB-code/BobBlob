using UnityEngine;
using UnityEngine.SceneManagement;

public class DieAndRespawnn : MonoBehaviour
{
    public GameObject player; //var for player
    public GameObject respawnPoint; //var for respawn point, seperate empty object

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player")) //checks if what hits it is the player
        {
            player.transform.position = respawnPoint.transform.position; //puts player at respawn point
            player.SetActive(false); //disables player (is tempoary) 
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
    }
}
