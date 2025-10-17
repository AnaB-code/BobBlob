using UnityEngine;

public class DeathCheck : MonoBehaviour
{
    public RespawnTimer rt;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnDisable()
    {
        rt.SetIsDead(true);
    }
}
