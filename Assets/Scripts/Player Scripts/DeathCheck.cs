using UnityEngine;

public class DeathCheck : MonoBehaviour {
    public RespawnTimer rt;
    public PlayerSounds ps;

    void OnDisable() {
        rt.SetIsDead(true);
        ps.DieSound();
    }
}
