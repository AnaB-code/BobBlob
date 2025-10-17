using UnityEngine;

public class RespawnTimer : MonoBehaviour
{
    public float respawnDelay; //var to hold the delay in respawn
    public GameObject player; //var for player
    public bool isDead = false; //var for storing weather or not the player is dead

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer();
    }

    void Timer()
    {
        if (isDead == true) //checks if player is dead
        {
            respawnDelay -= Time.deltaTime; //decreases timer
        }
        if (respawnDelay <= 0) //checks if timer is done, if done resets everything
        {
            respawnDelay = 1;
            player.SetActive(true);
            isDead = false;
        }
    }

    public void SetIsDead(bool deathStatus) //Setter for isDead
    {
        isDead = deathStatus;
    }
}
