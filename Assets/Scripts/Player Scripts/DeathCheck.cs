using UnityEngine;

public class DeathCheck : MonoBehaviour {
    public RespawnTimer rt;
    public PlayerSounds ps;
    public Grappler g;

    public GameObject myKiller;
    
    void OnDisable() {
        rt.SetIsDead(true);
        ps.DieSound();
        g.ResetGrappler();
    }

    public void KeelOver() {
        myKiller.GetComponent<DieAndRespawnn>().Murder();
    }
}
