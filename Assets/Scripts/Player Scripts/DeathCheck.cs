using UnityEngine;

public class DeathCheck : MonoBehaviour {
    public RespawnTimer rt;
    public PlayerSounds ps;
    public Grappler g;

    public GameObject respawnPoint;
	public GameObject myKiller;
	[SerializeField] GameObject myself;
    
    void OnDisable() {
        rt.SetIsDead(true);
        ps.DieSound();
        g.ResetGrappler();
    }

    public void KeelOver() {
        //myKiller.GetComponent<DieAndRespawnn>().Murder();
		this.transform.position = respawnPoint.transform.position; //puts player at respawn point
        myself.SetActive(false); //disables player (is tempoary) 
    }
}
