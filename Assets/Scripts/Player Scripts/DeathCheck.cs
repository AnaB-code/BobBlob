using UnityEngine;

public class DeathCheck : MonoBehaviour {
    public RespawnTimer rt;
    public PlayerSounds ps;
    public Grappler g;

    void OnDisable() {
        rt.SetIsDead(true);
        ps.DieSound();
        g.ResetGrappler();
    }
}
